# -*- coding: utf-8 -*-

from odoo import models, fields, api
from odoo.exceptions import ValidationError
import re

class tecnico(models.Model):
    _name = 'soporte.tecnico'
    _description = 'Modelo para la gestion de personas que solucionan incidencias'
    inherit = ['soporte.tecnico']
   
    tipo = fields.Selection(
        string='Tipo',
        selection=[('0', 'Tec. general'), ('1', 'Tec. Hardware'), ('2', 'Tec. Software'), ('3', 'Tec. Redes') ]
    )

    dni = fields.Char(
        string="DNI", 
        required=True, 
        size=9
    )
    
    apellido1 = fields.Char(
        string="Primer Apellido", 
        required=True
    )
    
    apellido2 = fields.Char(
        string="Segundo Apellido"
    )
    
    fecha_nacimiento = fields.Date(
        string="Fecha de Nacimiento"
    )
    
    fecha_incorporacion = fields.Datetime(
        string="Fecha de Incorporación", 
        default=fields.Datetime.now,
        readonly=True
    )

    foto = fields.Binary(
        string="Foto", 
        help="Tamaño máximo: 200x200",
        max_width=200,
        max_height=200
    )
    

    @api.constrains('dni')
    def _check_dni(self):
        regex = re.compile(r'^[0-9]{8}[A-Z]$', re.I)
        for record in self:
            if not regex.match(record.dni):
                raise ValidationError('ERROR. Formato DNI incorrecto. Debe ser 8 números seguidos de una letra.')

    # 🔹 Restricción SQL para que el DNI sea único
    _sql_constraints = [
        ('dni_unico', 'UNIQUE(dni)', "El DNI debe ser único."),
    ]
    """
    incidencias_ids = fields.Many2many(
        comodel_name='soporte.incidencia',  # Modelo relacionado
        relation='soporte_tecnico_incidencia_rel',  # Nombre de la tabla intermedia
        column1='tecnico_id',  # Nombre del campo en la tabla intermedia que apunta a este modelo
        column2='incidencia_id',  # Nombre del campo en la tabla intermedia que apunta al modelo relacionado
        string='Incidencias'
    )
    """