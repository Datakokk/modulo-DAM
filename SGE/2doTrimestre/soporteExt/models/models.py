# -*- coding: utf-8 -*-

from odoo import models, fields, api
from odoo.exceptions import ValidationError
import re

class tecnico(models.Model):
    _name = 'soporte.tecnico' #ESTE CAMPO SOLO ES OBLIGATORIO CUANDO HEREDEMOS DE MAS DE UN MODELO
    _inherit= ['soporte.tecnico','mail.thread']
    _description = 'Modelo para la gestion de personas que solucionan incidencias'
    _rec_name='nombre'
   

    display_name = fields.Char(
        compute="_compute_display_name", 
        store=True
    )
    @api.depends("nombre", "apellido1")
    def _compute_display_name(self):
        for record in self:
            record.display_name= f"{record.id}-{record.nombre}_{record.apellido1}"
    def name_get(self):
        return [(record.id, record.display_name) for record in self]

    tipo = fields.Selection(
        string='Tipo',
        selection=[('0', 'Tec. general'),('1', 'Tec. Hardware'),('2', 'Tec. Software'),('3', 'Tec. Redes')]
    )
    dni = fields.Char(
        string ='DNI',
        size = 9,
    )
    apellido1  = fields.Char(
        string='Primer apellido',
        #required = True,
    )
    apellido2  = fields.Char(
        string='Sgundo apellido',
        #required = True,
    )
    fecha_nacimiento = fields.Date(
        string='Fecha de nacimiento'
    )
    fecha_incorporacion  = fields.Date(
        string='Fecha incorporacion',
        #default=fields.Date.context_today,
        default=lambda self: fields.Datetime.now(),
        readonly = True,
    )
    foto  = fields.Image(
        string='Foto',
        max_width=200,
        max_height=200,
    )
#RESTICCIONES
    #EXPRESIONES REGULARES https://docs.python.org/es/3/library/re.html
    @api.constrains('dni')
    def _check_dni(self):
        regex = re.compile('[0-9]{8}[A-Z]\Z',re.I)
        for record in self:
            if not regex.match(record.dni):
                raise ValidationError('ERROR. Formato DNI incorrecto. ')

    _sql_constraints = [
        ('DNI_unico', 'UNIQUE(dni)', "El DNI debe ser único")
    ]