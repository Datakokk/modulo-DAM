# -*- coding: utf-8 -*-

from odoo import models, fields, api
from odoo.exceptions import ValidationError

class tecnico(models.Model):
    _name = 'soporte.tecnico'
    _description = 'Modelo para la gestion de personas que solucionan incidencias', 
    """_rec_name = 'nombre'"""
   
   
    tipo = fields.Selection(
        string='Tipo',
        selection=[('0', 'Tec. general'), ('1', 'Tec. Hardware'), ('2', 'Tec. Software'), ('0', 'Tec. Redes'), ]
    )
    """
    incidencias_ids = fields.Many2many(
        comodel_name='soporte.incidencia',  # Modelo relacionado
        relation='soporte_tecnico_incidencia_rel',  # Nombre de la tabla intermedia
        column1='tecnico_id',  # Nombre del campo en la tabla intermedia que apunta a este modelo
        column2='incidencia_id',  # Nombre del campo en la tabla intermedia que apunta al modelo relacionado
        string='Incidencias'
    )
    """
    