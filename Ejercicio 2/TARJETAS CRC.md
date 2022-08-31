[
  {
    "name": "AppointmentService",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Conocer si los datos de la consulta son válidos",
      "Conocer el ID de la consulta",
      "Crear la consulta",
      "Imprimir los datos de la consulta"
    ],
    "collaborators": [
      "Client",
      "Doctor",
      "Validate"
    ]
  },
  {
    "name": "Client",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Conocer el Nombre",
      "Conocer la Edad",
      "Conocer el ID del cliente",
      "Conocer el Número de teléfono",
      "Imprimir los datos del cliente"
    ],
    "collaborators": [
      ""
    ]
  },
  {
    "name": "Doctor",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Conocer el Nombre del doctor",
      "Conocer la Especialidad",
      "Conocer el Consultorio",
      "Imprimir los datos del doctor"
    ],
    "collaborators": [
      ""
    ]
  },
  {
    "name": "Validate",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Conocer si la consulta es valida",
      "Validar los datos del cliente",
      "Validar los datos del doctor",
      "Retornar si los datos de ambos son validos"
    ],
    "collaborators": [
      "Doctor",
      "Client"
    ]
  }
]