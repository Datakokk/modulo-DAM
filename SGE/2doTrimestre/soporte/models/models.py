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

     ubicacion_id = fields.Many2one(
        comodel_name = 'soporte.ubicacion',
        string = 'Ubicación con Many2one',
        ondelete = 'restrict',
        required=True
    )
     
     cerrada = fields.Boolean(
         string = 'Cerrada'
     )

class ubicacion(models.Model):
    _name = 'soporte.ubicacion'
    _description = 'Modelo para la gestión de ubicaciones'

    nombre = fields.Char(
        string = 'Nombre',
        required = True
    )

    pabellon = fields.Selection(
        string = 'Pabellón',
        selection = [('1', 'Pabellón Paris'), ('2', 'Pabellón Roma'), ('3', 'Pabellón Londres')]
    )

    plana = fields.Selection(
        string = 'Planta',
        selection = [('0', 'Planta baja'), ('1', 'Planta primera'), ('2', 'Planta segunda')]
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

# ubicacion = fields.Selection(
#      string='Ubicación',
#      selection=[
#          ('oficina', 'Oficina'),
#          ('almacen', 'Almacén'),
#          ('remoto', 'Remoto')
#      ]
#  )