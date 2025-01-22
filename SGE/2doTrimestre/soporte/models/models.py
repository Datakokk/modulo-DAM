#-*- coding: utf-8 -*-

from odoo import models, fields, api


class incidencia(models.Model):
     _name = 'soporte.incidencia'
     _description = 'Modelo para la gestión de incidencias'

     titulo = fields.Char(
        string = 'Título',
        required = True
    )

     descripcion = fields.Html(
         string = 'Descripción',
         required = True,
         help = 'Explicación de la incidencia ocurrida brevemente',
     )

     prioridad = fields.Integer(
         string = 'Prioridad',
         default = 0,
         help = 'Establece un valor mayor o igual a 10 para que se considere urgente',
     )

     urgente = fields.Boolean(
         string='Urgente',
         readonly = True,
     )

     archivos_adjuntos = fields.Binary(
         string = 'Archivos adjuntos'
     )

     imagen = fields.Image(
         string = 'Imagen',
         max_width = 250,
         max_height = 250
     )

     fecha_creacion = fields.Datetime(
         string = 'Fecha de creación',
         default = fields.Datetime.now
     )

     fecha_modificacion = fields.Date(
         string = 'Fecha de modificación',
         default = fields.Date.context_today
     )

     ubicacion = fields.Selection(
         string='Ubicación',
         selection=[
             ('oficina', 'Oficina'),
             ('almacen', 'Almacén'),
             ('remoto', 'Remoto')
         ]
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

