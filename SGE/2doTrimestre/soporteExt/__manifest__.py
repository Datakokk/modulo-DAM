# -*- coding: utf-8 -*-
{
    'name': "soporteExt",

    'summary': """Módulo para la gestion de incidencias de SGE Extendido""",

    'description': """
        Módulo para la gestion de incidencias de SGE. Extension para tecnicos
    """,

    'author': "Carlos Izquierdo",
    'website': "https://www.carlosig.es",

    # Categories can be used to filter modules in modules listing
    # Check https://github.com/odoo/odoo/blob/15.0/odoo/addons/base/data/ir_module_category_data.xml
    # for the full list
    'category': 'tools',
    'version': '0.1',

    # any module necessary for this one to work correctly
    'depends': ['base','soporte','mail'],

    # always loaded
    'data': [
        'security/groups.xml',
        'security/ir.model.access.csv',
        'views/views.xml',
    ],
    # only loaded in demonstration mode
    'demo': [
        'demo/demo.xml',
    ],
}


