#-*- coding: utf-8 -*-

from odoo import models, fields, api
from odoo.exceptions import ValidationError

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
     @api.constrains('prioridad')
     def _check_prioridad(self):
         for record in self:
             if record.prioridad > 10:
                 raise ValidationError('Error en prioridad(@api.constrains): no puede ser mayor que 10 ')

     urgente = fields.Boolean(
         string='Urgente',
         compute='_nombre_funcion',
         store=True
     )
     @api.depends('prioridad')
     def _nombre_funcion(self):
        for record in self:
            if record.prioridad >= 7:
                record.urgente = True
            else:
                record.urgente = False

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
     @api.onchange('titulo', 'descripcion', 'prioridad', 'ubicacion_id')
     def _onchange_fecha_modificacion(self):
         self.fecha_modificacion = fields.Datetime.now()

     sql_constraints = [
        ('Restricciones_menores_0', 'CHECK(prioridad >= 0)', 'Error en el campo prioridad: no puede ser menor que 0'),
     ]

     ubicacion_id = fields.Many2one(
        comodel_name = 'soporte.ubicacion',
        string = 'Ubicación con Many2one',
        ondelete = 'restrict',
        required=True
    )
     
     cerrada = fields.Boolean(
         string = 'Cerrada'
     )

     tecnico_ids = fields.Many2many('soporte.tecnico');

class ubicacion(models.Model):
    _name = 'soporte.ubicacion'
    _description = 'Modelo para la gestión de ubicaciones'

    nombre = fields.Char(
        string = 'Nombre',
        required = True
    )

    incidencias_ids = fields.One2many(
        comodel_name = 'soporte.incidencia',
        inverse_name = 'ubicacion_id',
        string = 'Incidencias'
    )

    pabellon = fields.Selection(
        string = 'Pabellón',
        selection = [('1', 'Pabellón Paris'), ('2', 'Pabellón Roma'), ('3', 'Pabellón Londres')]
    )

    planta = fields.Selection(
        string = 'Planta',
        selection = [('0', 'Planta baja'), ('1', 'Planta primera'), ('2', 'Planta segunda')]
    )

class tecnico(models.Model):
    _name = 'soporte.tecnico'
    _description = 'Modelo para la gestión de personas que solucionan incidencias'

    nombre = fields.Char(
        string = 'Nombre',
        required = True
    )

    apellidos = fields.Char(
        string = 'Apellidos',
        required = True
    )

    incidencias_ids = fields.Many2many('soporte.incidencia');

    # incidencias_ids = fields.Many2many(
    #     comodel_name = 'soporte.incidencia',
    #     relation = 'incidencias_tecnicos',
    #     column1 = 'tecnico_id',
    #     column2 = 'incidencia_id',
    #     string = 'Incidencias'
    # )

    # @api.depends('incidencias_ids')
    # def _compute_incidencias(self):
    #     for tecnico in self:
    #         tecnico.numero_incidencias = len(tecnico.incidencias_ids)

    # numero_incidencias = fields.Integer(
    #     string = 'Número de incidencias',
    #     compute = '_compute_incidencias'
    # )
   


 
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