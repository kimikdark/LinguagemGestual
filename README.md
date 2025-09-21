# Tradutor de Língua Gestual
## Sobre o Projeto

Este projeto é uma aplicação desktop desenvolvida em C# com **Windows Forms** que atua como um tradutor visual para a Língua Gestual Portuguesa. A aplicação permite que os utilizadores escrevam uma frase numa caixa de texto, e ao clicar num botão, a aplicação "soletra" a frase, exibindo as letras uma a uma através de imagens na língua gestual. O objetivo é criar uma ferramenta simples e acessível para a aprendizagem e demonstração do alfabeto gestual.

## Funcionalidades

* **Tradução em tempo real**: Converte texto para imagens da língua gestual, exibindo cada letra de forma sequencial.
* **Gestão de tempo**: Utiliza um `Timer` para controlar o tempo de exibição de cada letra, permitindo um ritmo de leitura ajustável.
* **Tratamento de caracteres**: O programa ignora caracteres não alfabéticos e processa acentos, convertendo-os para as suas letras base (por exemplo, "á" para "a").
* **Interface intuitiva**: Uma interface simples e limpa para fácil utilização.

## Tecnologias Utilizadas

* **C#**: Linguagem de programação principal.
* **Windows Forms**: Framework para a criação da interface gráfica.

## Como Executar o Projeto

1.  **Pré-requisitos**:
    * Visual Studio (versão 2019 ou superior).
    * .NET Framework 4.7.2 ou superior.

2.  **Clonar o Repositório**:
    ```bash
    git clone [https://github.com/kimikdark/LinguagemGestual.git](https://github.com/kimikdark/LinguagemGestual.git)
    ```

3.  **Abrir no Visual Studio**:
    * Abra o Visual Studio e selecione `File > Open > Project/Solution`.
    * Navegue até a pasta onde clonou o repositório e selecione o ficheiro `.sln`.

4.  **Compilar e Executar**:
    * Certifique-se de que a plataforma de solução está definida para `Debug` ou `Release`.
    * Pressione **F5** ou clique no botão `Start` para executar a aplicação.

## Imagens dos Recursos

Todas as imagens do alfabeto em Língua Gestual (A.JPG a Z.JPG) foram importadas como recursos do projeto para garantir que a aplicação funcione em qualquer ambiente, sem a necessidade de caminhos de ficheiro externos.
