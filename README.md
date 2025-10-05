# 🛍️ Sistema de Ventas Completo

## 📋 Descripción

Sistema integral de gestión de ventas desarrollado en **C#** con **Windows Forms** y **SQL Server**, implementando una arquitectura en capas (n-tier architecture) para garantizar la separación de responsabilidades y mantenibilidad del código.

Este proyecto fue desarrollado desde cero, codificado completamente a mano, con un diseño mejorado y enfocado en las mejores prácticas de desarrollo de software empresarial.

![Sistema de Ventas - Interfaz Principal](https://github.com/xfiberex/Sistema_Ventas_Completo/assets/135444565/8c5221c0-8ee9-4b6c-899f-0a6d061db6d1)

## 🏗️ Arquitectura del Proyecto

El sistema está estructurado en **4 capas principales**:

### 📊 **Capa de Datos (CapaDatos)**
- Gestión de conexiones a la base de datos
- Procedimientos almacenados y consultas SQL
- Acceso directo a SQL Server

### 🏢 **Capa de Entidades (CapaEntidad)**
- Modelos de datos y entidades del negocio
- Clases que representan las tablas de la base de datos
- DTOs (Data Transfer Objects)

### 💼 **Capa de Negocio (CapaNegocio)**
- Lógica de negocio y reglas empresariales
- Validaciones y procesamiento de datos
- Intermediario entre la capa de presentación y datos

### 🖥️ **Capa de Presentación (CapaPresentacion)**
- Interfaz de usuario con Windows Forms
- Formularios y controles de usuario
- Gestión de eventos y validaciones de UI

## ⚡ Características Principales

### 🔐 **Gestión de Usuarios y Seguridad**
- Sistema de autenticación con login seguro
- Gestión de roles y permisos
- Control de acceso por funcionalidades

### 📦 **Gestión de Inventario**
- Administración de productos y categorías
- Control de stock y existencias
- Gestión de proveedores

### 🛒 **Proceso de Ventas**
- Registro de ventas con detalles
- Gestión de clientes
- Facturación y comprobantes

### 📊 **Reportes y Análisis**
- Reportes de ventas detallados
- Reportes de compras
- Análisis de rendimiento

### 💰 **Gestión Financiera**
- Control de compras y gastos
- Seguimiento de ingresos
- Estados financieros básicos

## 🛠️ Tecnologías Utilizadas

| Tecnología | Versión | Uso |
|------------|---------|-----|
| **C#** | .NET Framework 4.8.1 | Lenguaje principal |
| **Windows Forms** | - | Interfaz de usuario |
| **SQL Server** | Express/Standard | Base de datos |
| **Visual Studio** | 2022 | IDE de desarrollo |

## 📂 Estructura del Proyecto

```
Sistema_Ventas_Completo/
├── 📁 CapaDatos/           # Acceso a datos
├── 📁 CapaEntidad/         # Modelos y entidades
├── 📁 CapaNegocio/         # Lógica de negocio
├── 📁 CapaPresentacion/    # Interfaz de usuario
│   ├── 📁 Formularios/     # Windows Forms
│   ├── 📁 Iconos/          # Recursos gráficos
│   └── 📁 Utilidades/      # Herramientas auxiliares
└── 📄 README.md
```

## 📋 Módulos del Sistema

### 👥 **Gestión de Usuarios**
- Crear, editar y eliminar usuarios
- Asignación de roles y permisos
- Control de estado de usuarios

### 🏪 **Información del Negocio**
- Configuración de datos de la empresa
- Personalización de la aplicación

### 📦 **Gestión de Productos**
- CRUD completo de productos
- Categorización y clasificación
- Control de precios y stock

### 🚚 **Gestión de Proveedores**
- Registro de proveedores
- Información de contacto
- Historial de compras

### 👤 **Gestión de Clientes**
- Base de datos de clientes
- Información de contacto
- Historial de compras

### 🛒 **Proceso de Ventas**
- Interfaz de punto de venta
- Gestión de carritos de compra
- Generación de facturas

### 📊 **Reportes**
- Reportes de ventas por período
- Reportes de compras
- Análisis de productos más vendidos

## 🚀 Instalación y Configuración

### Prerrequisitos
- Windows 10/11
- .NET Framework 4.8.1 o superior
- SQL Server Express/Standard
- Visual Studio 2019/2022 (recomendado)

### Pasos de Instalación

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/xfiberex/Sistema_Ventas_Completo.git
   ```

2. **Configurar la base de datos**
   - Crear una base de datos llamada `DBSISTEMA_VENTA`
   - Ejecutar los scripts SQL proporcionados
   - Actualizar la cadena de conexión en `App.config`

3. **Configurar la cadena de conexión**
   ```xml
   <connectionStrings>
     <add name="cadenaConexion" 
          connectionString="Data Source=TU_SERVIDOR;Initial Catalog=DBSISTEMA_VENTA;Integrated Security=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. **Compilar y ejecutar**
   - Abrir la solución en Visual Studio
   - Restaurar paquetes NuGet si es necesario
   - Compilar la solución (F6)
   - Ejecutar el proyecto (F5)

## 📸 Capturas de Pantalla

### Pantalla de Login
![Login](ruta-a-imagen-login)

### Dashboard Principal
![Dashboard](ruta-a-imagen-dashboard)

### Gestión de Productos
![Productos](ruta-a-imagen-productos)

## 🤝 Contribuciones

Las contribuciones son bienvenidas. Para contribuir:

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📝 Licencia

Este proyecto está bajo la Licencia MIT. Ver el archivo [LICENSE](LICENSE.txt) para más detalles.

## 👨‍💻 Autor

**xfiberex**
- GitHub: [@xfiberex](https://github.com/xfiberex)

## 📞 Soporte

Si tienes alguna pregunta o necesitas ayuda, puedes:
- Abrir un [Issue](https://github.com/xfiberex/Sistema_Ventas_Completo/issues)
- Contactar al desarrollador a través de GitHub

## 🔄 Versiones

- **v1.0.0** - Versión inicial con funcionalidades básicas
- Próximas versiones incluirán mejoras en la UI y nuevas características

---

⭐ **¡No olvides dar una estrella al proyecto si te fue útil!**
