# -*- coding: utf-8 -*-
{
    'name': "soporteExt",

    'summary': """Módulo Extendido para la gestion de tecnicos de SGE""",

    'description': """
        Módulo para la gestion de tecnicos de SGE
    """,

    'author': "Carlos Fernando",
    'website': "https://www.carlos.es",

    # Categories can be used to filter modules in modules listing
    # Check https://github.com/odoo/odoo/blob/15.0/odoo/addons/base/data/ir_module_category_data.xml
    # for the full list
    'category': 'tools',
    'version': '0.1',

    # any module necessary for this one to work correctly
    'depends': ['base', 'soporte'],

    # always loaded
    'data': [
        'security/groups.xml',
        'security/ir.model.access.csv',
        'views/views.xml',
        'views/templates.xml',
        'demo/demo.xml'
    ],
    # only loaded in demonstration mode
    'demo': [
        'demo/demo.xml',
    ],
}


