# XsltCraft v1.0

**XsltCraft** is a browser-based XSLT development playground that allows users to write, edit, test, and preview XSLT transformations against XML documents in real time.

It provides a developer-friendly interface with a powerful code editor, template library, and live HTML preview.

![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)
![React](https://img.shields.io/badge/React-19.2-61DAFB?logo=react&logoColor=white)
![TypeScript](https://img.shields.io/badge/TypeScript-5.9-3178C6?logo=typescript&logoColor=white)
![Vite](https://img.shields.io/badge/Vite-8-646CFF?logo=vite&logoColor=white)
![Monaco Editor](https://img.shields.io/badge/Monaco_Editor-4.7-007ACC?logo=visualstudiocode&logoColor=white)
![FlexLayout](https://img.shields.io/badge/FlexLayout-0.8-4A90D9)
![License](https://img.shields.io/badge/License-MIT-green)
![Status](https://img.shields.io/badge/status-active-brightgreen)
---

## Features

* XSLT editing with **Monaco Editor**
* **Live preview** of transformed HTML
* **XML file upload**
* **Template library** (Invoice, Despatch)
* **Template editing and saving**
* **Image asset support** (Logo, Signature)
* Dockable and resizable layout
* Dark theme developer interface
---

## Tech Stack

* React 19
* TypeScript
* Vite
* Monaco Editor
* flexlayout-react
* .NET Backend API (XSLT Transformation)

---

## Application Layout

The interface consists of three main panels:

```
Template Library | XSLT Editor | HTML Preview
```

### Panels

**Template Library**

* Browse available XSLT templates
* Categories such as:

  * invoice
  * despatch

**XSLT Editor**

* Edit XSLT stylesheets
* Powered by Monaco Editor
* Syntax highlighting and developer-friendly editing

**Preview Panel**

* Shows the transformed HTML output
* Rendered inside an iframe

---

## How It Works

1. Upload an XML file or select a template
2. Edit the XSLT stylesheet
3. The application sends the XML + XSLT to the backend API
4. The backend performs the transformation
5. The resulting HTML is displayed in the preview panel

---

## Backend Requirement

XsltCraft UI requires a backend API capable of performing XSLT transformations.


Expected workflow:

```
XML + XSLT → Backend API → Transformed HTML → Preview
```

---

## Installation

Clone the repository:

```
git clone https://github.com/yourusername/xsltcraft-ui.git
```

Navigate into the project:

```
cd xsltcraft-ui
```

Install dependencies:

```
npm install
```

Start the development server:

```
npm run dev
```

Open in browser:

```
http://localhost:5173
```

---

## Project Structure

```
src
│
├ components
│   ├ TemplateList.tsx
│   ├ XsltEditor.tsx
│   ├ XmlEditor.tsx
│   ├ PreviewPanel.tsx
│   └ Toolbar.tsx
│
├ pages
│   └ Playground.tsx
│
├ services
│   └ transformService.ts
│
└ main.tsx
```

## Contributing

Contributions are welcome.

If you'd like to improve the project:

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Open a pull request

---

## License

This project is licensed under the MIT License.

---

## Author

Developed by **Semih Polat**
