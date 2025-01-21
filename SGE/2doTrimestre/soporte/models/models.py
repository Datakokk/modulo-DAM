#-*- coding: utf-8 -*-

from odoo import models, fields, api


class incidencia(models.Model):
     _name = 'soporte.incidencia'
     _description = 'Modelo para la gestión de incidencias'

    descripcion = fields.Char(
        string = 'Descripcion',
    )

    prioridad = fields.Integer(
        string = 'Prioridad',
    )

    urgente = fields.Selection(
        [('0', 'No'), ('1','si')], 
        string='Urgente'
    )

    cerrada = fields.Boolean(
        string = 'Cerrada'
    )
#     name = fields.Char()
#     value = fields.Integer()
#     value2 = fields.Float(compute="_value_pc", store=True)
#     description = fields.Text()
#
#     @api.depends('value')
#     def _value_pc(self):
#         for record in self:
#             record.value2 = float(record.value) / 100

