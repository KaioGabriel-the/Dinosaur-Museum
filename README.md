# Dinosaur Museum 🦖🏛️

Meu Primeiro Ambiente em Realidade Virtual desenvolvido no Unity.

## 📌 Descrição

O **Dinosaur Museum** é um ambiente simples em VR que simula um pequeno museu/jardim de dinossauros.  
O projeto foi desenvolvido com foco nos fundamentos de XR (Extended Reality), organização de cena e configuração para build em Android (Meta Quest).
A aplicação pode ser executada no Editor do Unity (PC) e está preparada para build em dispositivos Meta Quest.

---
## 🎯 Objetivos do Projeto

- Criar uma cena 3D navegável
- Utilizar pelo menos 5 objetos 3D
- Configurar ambiente com chão e skybox
- Organizar corretamente a hierarquia do projeto
- Preparar build para Android (Meta Quest)
- Documentar o projeto adequadamente
- Adicionar interação com objetos

---

## 🛠️ Tecnologias Utilizadas

![Unity](https://img.shields.io/badge/unity-000000.svg?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/c%23-239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![XR](https://img.shields.io/badge/xr-6E00FF.svg?style=for-the-badge)
![Android](https://img.shields.io/badge/android-3DDC84.svg?style=for-the-badge&logo=android&logoColor=white)
![Meta Quest](https://img.shields.io/badge/meta%20quest-0467DF.svg?style=for-the-badge)

- **Engine**: Unity  
- **Linguagem**: C#  
- **SDK XR**: Meta XR SDK  
- **Gerenciamento XR**: XR Plugin Management  
- **Plataforma Alvo**: Android (Meta Quest)  
- **Versionamento**: Git e GitHub

---

## 📂 Estrutura do Projeto

```bash
dinosaur-museum/
│
├── Assets/                # Recursos principais do projeto Unity
│   ├── Materials/         # Materiais aplicados nos modelos 3D
│   ├── Models/            # Modelos 3D dos dinossauros e ambiente
│   ├── Oculus/            # Configurações e integrações do Meta XR SDK
│   ├── Plugins/           # Plugins externos utilizados no projeto
│   ├── Resources/         # Recursos carregados dinamicamente
│   ├── Scenes/            # Cenas do projeto (menu, museu, etc.)
│   ├── Settings/          # Configurações específicas do projeto
│   ├── TutorialInfo/      # Arquivos padrão criados pela Unity
│   └── XR/                # Configurações relacionadas ao XR
│
├── Packages/              # Gerenciador de pacotes da Unity
├── ProjectSettings/       # Configurações globais do projeto
│
├── .gitignore             # Arquivos ignorados pelo Git
├── README.md              # Documentação do projeto
└── dinosaur_museum.slnx   # Arquivo de solução C#

````

---

## 🚀 Como Executar o Projeto

### 🖥️ Executar no Meta XR Simulator (Unity)

O projeto pode ser testado diretamente no Editor da Unity utilizando o **Meta XR Simulation**, sem necessidade de um dispositivo físico.

### ✅ Pré-requisitos
  * Unity (mesma versão utilizada no desenvolvimento)
  * Meta XR SDK instalado
  * XR Plugin Management configurado
  * Android Build Support (recomendado)

### ▶️ Passo a Passo

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/dinosaur-museum.git
   ````
### ▶️ Executar no Meta XR Simulator (Unity)

1. Abra o projeto na Unity.

2. Certifique-se de que o **XR Plugin Management** está ativado:

    ```bash
     Edit → Project Settings → XR Plugin Management
    ````

3. Verifique se o **Meta XR** está habilitado.

4. Abra a cena principal localizada em:

    ```bash
         Assets/Scenes/
    ````
    
5. Ative o **Meta XR Simulator**:
   * Vá até o menu do Meta XR
   * Selecione a opção de simulação (**XR Simulation**)

6. Clique em **Play** no Editor.

---
## 📸 Screenshots

> Imagens do ambiente em execução utilizando o Meta XR Simulator dentro da Unity.

### 🖥️ Execução no Meta XR Simulator (Unity)

![Simulator Screenshot](./images/simulator.png)

---
## 🧠 Desafios e Aprendizados

Durante o desenvolvimento do Dinosaur Museum, alguns desafios foram enfrentados:

- Configuração correta do ambiente XR no Unity
- Integração do Meta XR SDK com o XR Plugin Management
- Utilização do Meta XR Simulation para testar o ambiente sem o dispositivo físico
- Ajustes e configuração do projeto especificamente para Meta Quest
- Preparação de build para Android (Meta Quest)
- Organização adequada da hierarquia da cena
- Primeiros scripts em C# aplicados na Unity para controle básico de comportamento

### 📚 Principais Aprendizados

- Criação e configuração de projetos voltados para dispositivos Meta Quest
- Uso do Meta XR Simulation para testes e validação em ambiente VR
- Estruturação de projetos XR na Unity
- Aplicação de conceitos básicos de C# dentro da Unity (scripts, componentes e organização)
- Preparação de builds para dispositivos VR standalone
- Organização e documentação profissional de projetos
- Boas práticas de versionamento com Git

---

## 🚀 Melhorias Futuras

- Inserir áudio ambiente imersivo
- Criar sistema de informações interativas para cada dinossauro
- Implementar sistema de locomoção mais avançado

---

## 👨‍💻 Autor

**Kaio Gabriel**

Estou muito feliz com o meu primeiro projeto em Realidade Virtual.  
Este projeto marca o início da minha jornada no desenvolvimento XR 🚀🥽

## 📱 Contato

[![E-mail](https://img.shields.io/badge/-Email-9B59B6?style=for-the-badge&logo=microsoft-outlook&logoColor=white)](mailto:kkaiogabrielk@gmail.com)
[![LinkedIn](https://img.shields.io/badge/linkedin-%239B59B6.svg?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/kaio-gabriel-de-sousa-carvalho-baa05b313/)
[![GitHub](https://img.shields.io/badge/GitHub-9B59B6?style=for-the-badge&logo=github&logoColor=white)](https://github.com/KaioGabriel-the)
