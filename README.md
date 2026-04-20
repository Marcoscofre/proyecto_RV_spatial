# 🧠 Aulas Virtuales para Neurodivergencia — DIREXLAB

> Proyecto de Título · Francisco & Marcos · Universidad · 2025  
> Desarrollado en colaboración con el equipo de **DIREXLAB**

---

## 📖 Descripción

Este proyecto consiste en la creación de **aulas virtuales inmersivas en Realidad Virtual** orientadas a personas con neurodivergencia (TEA, TDAH, dislexia, entre otras). El entorno busca ofrecer espacios de aprendizaje accesibles, estimulantes y personalizables dentro de una plataforma de mundo virtual.

El proyecto fue construido con **Unity** y publicado en **Spatial.io**, permitiendo el acceso desde navegador sin necesidad de hardware especializado.

> ⚠️ **Rama de producción:** La versión final desplegada en Spatial se encuentra en la rama [`Avances_marcos`](../../tree/Avances_marcos). Allí reside toda la información actualizada del proyecto. La rama `main` contiene únicamente la versión preliminar.

---

## 🌐 Acceso directo al mundo virtual

Puedes ingresar al mundo sin instalaciones, directo desde el navegador:

**[👉 Direxlab Museo en Spatial.io](https://www.spatial.io/s/Direxlab-museo-67fde8f172cf55d3b7251704?share=7789553473583613806)**

---

## 🛠️ Tecnologías utilizadas

| Tecnología | Versión | Uso |
|---|---|---|
| [Unity](https://unity.com/) | `2021.3.44f1` (LTS) | Motor principal de desarrollo 3D |
| [Spatial SDK](https://docs.spatial.io) | `1.67.0` | Integración y despliegue en Spatial.io |
| [Universal Render Pipeline (URP)](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest) | — | Renderizado optimizado para web/móvil |
| [TextMesh Pro](https://docs.unity3d.com/Manual/com.unity.textmeshpro.html) | — | Tipografías y texto dentro del mundo |
| [Addressables](https://docs.unity3d.com/Packages/com.unity.addressables@latest) | — | Gestión de assets y carga dinámica |
| C# | — | Scripting y lógica del proyecto |

---

## 💻 Instalación y configuración local

### Requisitos previos

- **Unity Hub** instalado → [Descargar aquí](https://unity.com/download)
- **Unity versión `2021.3.44f1`** (LTS recomendada para compatibilidad)
- **Git** instalado en tu máquina

### 1. Clonar el repositorio

```bash
# Clonar la rama de producción (versión final desplegada)
git clone --branch Avances_marcos https://github.com/Marcoscofre/proyecto_RV_spatial.git

# O clonar main (versión preliminar)
git clone https://github.com/Marcoscofre/proyecto_RV_spatial.git
```

### 2. Abrir el proyecto en Unity

1. Abre **Unity Hub**
2. Haz clic en **"Add"** → **"Add project from disk"**
3. Selecciona la carpeta clonada `proyecto_RV_spatial`
4. Unity Hub detectará automáticamente la versión `2021.3.44f1`  
   > Si no la tienes instalada, Unity Hub te ofrecerá descargarla automáticamente
5. Abre el proyecto y espera a que Unity importe todos los assets (puede tomar varios minutos la primera vez)

### 3. Instalar el Spatial SDK

El SDK ya está incluido en el proyecto mediante el archivo `Packages/manifest.json`. Al abrir Unity, los paquetes se instalarán automáticamente.

Para verificar la instalación:
- Ve a **Window → Package Manager**
- Confirma que **Spatial SDK** aparece instalado en versión `1.67.0`

### 4. Configuración básica

1. Abre la escena principal desde `Assets/` (busca archivos `.unity`)
2. En la barra superior ve a **Spatial → Config** para revisar las credenciales del mundo
3. Para hacer pruebas locales usa **Spatial → Test Active Scene**

### 5. Despliegue en Spatial (opcional)

1. Inicia sesión en tu cuenta de [Spatial.io](https://www.spatial.io)
2. En Unity ve a **Spatial → Publish**
3. Sigue los pasos del asistente de publicación

---

## 📁 Estructura del repositorio

```
proyecto_RV_spatial/
├── Assets/
│   ├── 3Dfrk/          # Frames y elementos decorativos
│   ├── Spatial/         # Assets y configuraciones del SDK de Spatial
│   ├── Examples/        # Escenas y prefabs de ejemplo del SDK
│   └── TextMesh Pro/    # Fuentes y materiales de texto
├── Packages/
│   └── manifest.json    # Dependencias del proyecto
├── ProjectSettings/     # Configuración general de Unity
└── README.md
```

---

## 👥 Equipo

| Nombre | Rol |
|---|---|
| **Francisco** | Desarrollador — Trabajo de Título |
| **Marcos** | Desarrollador — Trabajo de Título |
| **Equipo DIREXLAB** | Dirección y apoyo metodológico |

---

## 📄 Licencia

Revisa el archivo [LICENSE](./LICENSE) para más información.

