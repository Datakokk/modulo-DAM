# -*- coding: utf-8 -*-

from odoo import models, fields, api
from odoo.exceptions import ValidationError

class incidencia(models.Model):
    _name = 'soporte.incidencia'
    _description = 'Modelo para la gestion de incidencias'
    _rec_name = 'titulo'

    def informe_incidencia_boton(self):
        return self.env.ref('soporte.action_informe_incidencia').report_action(self)

    titulo = fields.Char(
        string='Titulo',
        required=True,
        default = 'Incidencia X'
    )

    descripcion = fields.Html(
        string='Descripcion',
        help='Explicacion de la incidencia ocurrida brevemente',
        required=True
    )
    
    prioridad = fields.Integer(
        string='Prioridad',
        default=0,
        help='Establece un valor entre 0 y 10.Si el valor es mayor de 7 sera considerada urgente'
    )

    urgente = fields.Boolean(
        string='Urgente',
        compute='_compute_urgente',
        store=True
    )
        
    @api.depends('prioridad')
    def _compute_urgente(self):
        for record in self:
            if record.prioridad > 7:
                record.urgente = True
            else:
                record.urgente = False

    @api.constrains('prioridad')
    def _check_prioridad(self):
        for record in self:
            if record.prioridad > 10:
                raise ValidationError("Error en prioridad(@api.constrains)Debe in troducir un numero menor que 11")

    @api.constrains('fieldname')
    def _constrains_fieldname(self):
        pass

    cerrada = fields.Boolean(
        string='Cerrada',
    )
    """
    ubicacion = fields.Selection(
        string='Ubicacion',
        selection=[('1', 'Aula 203'),('2', 'Aula 204'),('3', 'Aula 205')]
        
    ) 
    """ 
    ubicacion_id = fields.Many2one(
        comodel_name='soporte.ubicacion',
        string='Ubicacion',
        ondelete='restrict',
    )
    archivo = fields.Binary(
        string='Archivo adjunto',
    )
    foto = fields.Image(
        string='Foto', 
        max_width=250, max_height=250
    )
    fecha_creacion = fields.Datetime(
        tring='Fecha_creacion',
        default=fields.Datetime.now,
    )
    fecha_modificacion = fields.Datetime(
        
        string='Fecha ultima modificacion',
        default= lambda self: fields.Datetime.now()
    )
    @api.onchange('titulo','descripcion','prioridad','ubicacion_id','cerrada','archivo')
    def _onchange_fecha_modificacion(self):
        self.fecha_modificacion = fields.Datetime.now()


    """
    tecnicos_ids = fields.Many2many(
        comodel_name='soporte.tecnico',  # Modelo relacionado
        relation='soporte_tecnico_incidencia_rel',  # Nombre de la tabla intermedia
        column1='incidencia_id',  # Nombre del campo en la tabla intermedia que apunta a este modelo
        column2='tecnico_id',  # Nombre del campo en la tabla intermedia que apunta al modelo relacionado
        string='Técnicos Asignados'
    )
    """
    tecnico_ids = fields.Many2many('soporte.tecnico')

    _sql_constraints = [
        ("constraint_intervalo_prioridad", "CHECK(prioridad>=0)", "La prioridad debe ser mayor a 0")
    ]
class ubicacion(models.Model):
    _name = 'soporte.ubicacion'
    _description = 'Modelo para la gestion de ubicaciones'
    _rec_name = 'nombre' #el campo que usará en las relaciones
   
   
    nombre = fields.Char(
        string='Nombre',
        required=True
    )
    incidencias_ids = fields.One2many(
    comodel_name='soporte.incidencia',  # Modelo relacionado
    inverse_name='ubicacion_id',       # Campo Many2one en el modelo relacionado
    string='Incidencias'
    )


    pabellon = fields.Selection(
        string='Pabellon',
        selection=[('1', 'Pabellon Paris'),('2', 'Pabellon Roma'),('3', 'Pabellon Londres')]
    )
    planta = fields.Selection(
        string='Planta',
        selection=[('0', 'Planta baja'),('1', 'Planta primera'),('2', 'Planta segunda')]
    )

class tecnico(models.Model):
    _name = 'soporte.tecnico'
    _description = 'Modelo para la gestion de personas que solucionan incidencias'
   
   
    nombre = fields.Char(
        string='Nombre',
        required=True,
        default = 'Tecnico X'
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
    incidencia_ids = fields.Many2many('soporte.incidencia')