```json
{
  "editor.fontFamily": "'JetBrains Mono', monospace",
  "editor.fontSize": 14,
  "editor.fontLigatures": true,
  "editor.formatOnSave": true,
  "editor.tabSize": 4,
  "editor.insertSpaces": true,
  "editor.minimap.enabled": false,
  "files.autoSave": "afterDelay",
  "files.autoSaveDelay": 1000,
  "terminal.integrated.fontFamily": "'JetBrains Mono', monospace",
  "terminal.integrated.fontSize": 14,
  "terminal.integrated.lineHeight": 1.2
}
```
# Aula de POO com C# (.NET)

## 1. Verificar o ambiente

```bash
dotnet --version
```

## 2. Duas formas de executar C#

### A) Ficheiro único (exemplos rápidos)

Crie um ficheiro `.cs` numa pasta **sem** `.csproj` (por exemplo `exemplos/`):

```bash
cd exemplos
dotnet run HerancaImoveis.cs
```

### B) Projeto (programas maiores)

```bash
dotnet new console -o NomeDoProjeto
cd NomeDoProjeto
dotnet run
```

## 3. Comandos úteis

| Comando | O que faz |
|---|---|
| `dotnet run` | Compila e executa |
| `dotnet build` | Só compila (mostra erros) |
| `dotnet clean` | Apaga ficheiros compilados |
| `dotnet new list` | Lista os modelos de projeto |

## 4. Erros comuns

- **"Couldn't find a project to run"**: está numa pasta sem `.csproj`. Entre na pasta do projeto (`cd NomeDoProjeto`) ou use um ficheiro único.
- **Duas classes `Program`/`Main`**: há dois ficheiros `.cs` na mesma pasta de projeto. Mantenha um só `Main` por projeto.
- **Erro de compilação**: leia a linha indicada, o compilador diz o ficheiro e a linha (ex.: `Program.cs(12,5)`).

## 5. Estrutura sugerida

```
aula-POO/
├── exemplos/          ← ficheiros .cs soltos
├── HerancaImoveis/    ← projeto
└── README.md
```
