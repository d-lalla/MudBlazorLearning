# MudBlazor Learning - Guida Completa per Principianti

Un progetto didattico completo per imparare **Blazor**, **MudBlazor** e **C#** rapidamente, pensato specialmente per sviluppatori con esperienza Java.

## 📚 Indice

- [Introduzione](#introduzione)
- [Tecnologie](#tecnologie)
- [Prerequisiti](#prerequisiti)
- [Installazione](#installazione)
- [Struttura del Progetto](#struttura-del-progetto)
- [Guida per Java Developers](#guida-per-java-developers)
- [Concetti Fondamentali](#concetti-fondamentali)
- [Pagine di Esempio](#pagine-di-esempio)
- [CRUD Completo](#crud-completo)
- [Best Practices](#best-practices)
- [Risorse Aggiuntive](#risorse-aggiuntive)

## 🎯 Introduzione

Questo progetto è stato creato per aiutarti a imparare **Blazor Server** e **MudBlazor** in modo rapido ed efficace. Include esempi pratici di tutti i componenti principali, form con validazione, tabelle interattive e un esempio completo di CRUD (Create, Read, Update, Delete).

### Cosa Imparerai

- ✅ **Blazor Server**: Framework web moderno di Microsoft per creare applicazioni interattive
- ✅ **C#**: Linguaggio di programmazione object-oriented (molto simile a Java)
- ✅ **MudBlazor**: Libreria UI Material Design per Blazor
- ✅ **Razor Components**: Componenti riutilizzabili per costruire interfacce
- ✅ **Dependency Injection**: Pattern per gestire le dipendenze (simile a Spring)
- ✅ **Data Binding**: Collegamento bidirezionale tra UI e dati
- ✅ **Validazione**: DataAnnotations per validare i form
- ✅ **Dialogs e Snackbars**: Componenti di interazione con l'utente

## 🛠 Tecnologie

- **[Blazor Server](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)** - Framework per applicazioni web interattive
- **[MudBlazor 7.8.0](https://mudblazor.com/)** - Libreria UI Material Design
- **[.NET 8.0](https://dotnet.microsoft.com/)** - Piattaforma di sviluppo Microsoft
- **C# 12** - Linguaggio di programmazione

## 📋 Prerequisiti

### Software Necessario

1. **[.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)** o superiore
2. **Editor di codice** (uno di questi):
   - [Visual Studio 2022](https://visualstudio.microsoft.com/) (consigliato, versione Community gratuita)
   - [Visual Studio Code](https://code.visualstudio.com/) con estensione C#
   - [JetBrains Rider](https://www.jetbrains.com/rider/)

### Conoscenze Consigliate

- Programmazione base (variabili, cicli, condizioni)
- Concetti OOP (classi, ereditarietà, interfacce)
- **Opzionale**: HTML/CSS di base
- **Se vieni da Java**: la transizione sarà molto naturale!

## 🚀 Installazione

### 1. Clona il Repository

```bash
git clone <url-repository>
cd MudBlazorLearning
```

### 2. Ripristina i Pacchetti NuGet

```bash
dotnet restore
```

### 3. Avvia l'Applicazione

```bash
dotnet run
```

Oppure, se usi Visual Studio, premi `F5` per avviare in debug.

### 4. Apri nel Browser

L'applicazione sarà disponibile su:
- `https://localhost:5001`
- `http://localhost:5000`

## 📁 Struttura del Progetto

```
MudBlazorLearning/
├── Pages/                      # Pagine dell'applicazione
│   ├── Index.razor            # Homepage
│   ├── Dashboard.razor        # Dashboard con statistiche
│   ├── Buttons.razor          # Esempi di bottoni
│   ├── Typography.razor       # Esempi di tipografia
│   ├── Cards.razor            # Esempi di card
│   ├── Forms.razor            # Esempi di form e input
│   ├── Validation.razor       # Form con validazione
│   ├── Tables.razor           # Tabelle interattive
│   ├── Dialogs.razor          # Dialog (finestre modali)
│   ├── Snackbars.razor        # Notifiche snackbar
│   └── Students.razor         # CRUD completo studenti
├── Shared/                     # Componenti condivisi
│   ├── MainLayout.razor       # Layout principale
│   ├── NavMenu.razor          # Menu di navigazione
│   └── Dialogs/               # Dialog personalizzati
│       ├── SimpleDialog.razor
│       ├── ConfirmDialog.razor
│       ├── FormDialog.razor
│       ├── StudentDialog.razor
│       └── StudentViewDialog.razor
├── Models/                     # Modelli dati (come Entity in Java)
│   └── Student.cs             # Modello Studente
├── Services/                   # Servizi applicazione (come Service in Spring)
│   └── StudentService.cs      # Servizio gestione studenti
├── wwwroot/                    # File statici
│   └── css/
│       └── site.css           # Stili personalizzati
├── App.razor                   # Root component
├── _Imports.razor             # Import globali
├── Program.cs                 # Entry point (come main in Java)
└── MudBlazorLearning.csproj   # File di progetto (come pom.xml)
```

## ☕ Guida per Java Developers

Se vieni da Java, troverai molte similitudini in C#. Ecco una guida rapida:

### Confronto Sintassi

| Concetto | Java | C# |
|----------|------|-----|
| **Classe** | `public class User { }` | `public class User { }` |
| **Property** | `private String name;`<br>`public String getName() { return name; }`<br>`public void setName(String name) { this.name = name; }` | `public string Name { get; set; }` |
| **Costruttore** | `public User(String name) { this.name = name; }` | `public User(string name) { Name = name; }` |
| **Ereditarietà** | `extends` | `:` |
| **Interfacce** | `implements` | `:` |
| **Generics** | `List<String>` | `List<string>` |
| **Async** | `CompletableFuture<User>` | `Task<User>` |
| **Null safety** | `@Nullable`, `Optional` | `string?` (nullable reference types) |
| **String** | `String` | `string` |
| **Lambda** | `(x) -> x + 1` | `(x) => x + 1` |
| **LINQ** | Stream API | LINQ (più potente) |

### Esempio: Modello Dati

**Java (con Lombok)**
```java
@Entity
@Data
public class Student {
    @Id
    @GeneratedValue
    private Long id;

    @NotNull
    @Size(min = 2, max = 50)
    private String firstName;

    @Email
    private String email;

    private int age;
}
```

**C# (Blazor)**
```csharp
public class Student
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string FirstName { get; set; } = "";

    [EmailAddress]
    public string Email { get; set; } = "";

    public int Age { get; set; }
}
```

### Esempio: Servizio

**Java (Spring)**
```java
@Service
public class StudentService {
    @Autowired
    private StudentRepository repository;

    public List<Student> findAll() {
        return repository.findAll();
    }
}
```

**C# (Blazor)**
```csharp
public class StudentService
{
    public Task<List<Student>> GetAllAsync()
    {
        // ... implementazione
    }
}

// Registrazione in Program.cs (come @Service in Spring)
builder.Services.AddSingleton<StudentService>();
```

### Dependency Injection

In Blazor, la Dependency Injection funziona come in Spring:

```csharp
// Registrazione servizio (Program.cs)
builder.Services.AddSingleton<StudentService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddTransient<EmailService>();

// Uso in un componente (come @Autowired in Spring)
@inject StudentService StudentService

@code {
    protected override async Task OnInitializedAsync()
    {
        var students = await StudentService.GetAllAsync();
    }
}
```

**Scope dei servizi:**
- `AddSingleton` → Come `@Singleton` (un'istanza per tutta l'app)
- `AddScoped` → Come `@RequestScoped` (un'istanza per richiesta/circuito)
- `AddTransient` → Come `@Dependent` (nuova istanza ogni volta)

## 💡 Concetti Fondamentali

### 1. Razor Components

I componenti Razor (file `.razor`) sono simili ai componenti React o Vue, ma scritti in C#:

```razor
@page "/counter"

<h1>Counter: @currentCount</h1>
<button @onclick="IncrementCount">Clicca</button>

@code {
    private int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }
}
```

**Elementi chiave:**
- `@page` → Definisce la route (URL)
- `@code` → Blocco di codice C#
- `@` → Sintassi per espressioni C# nell'HTML
- `@onclick` → Event handler (come `onClick` in React)

### 2. Data Binding

Il data binding collega i dati del codice all'interfaccia:

```razor
<!-- One-way binding (solo lettura) -->
<p>Nome: @nome</p>

<!-- Two-way binding (bidirezionale) -->
<MudTextField @bind-Value="nome" Label="Nome" />

@code {
    private string nome = "";
}
```

### 3. Parameter e Cascading Parameters

I parametri permettono di passare dati tra componenti:

```razor
<!-- Componente figlio -->
<ChildComponent Title="Ciao" Count="5" />

<!-- ChildComponent.razor -->
@code {
    [Parameter]
    public string Title { get; set; } = "";

    [Parameter]
    public int Count { get; set; }
}
```

### 4. Lifecycle Methods

I metodi del ciclo di vita sono simili a quelli di React:

```csharp
protected override void OnInitialized()
{
    // Come constructor - eseguito una volta
}

protected override async Task OnInitializedAsync()
{
    // Versione async - per chiamate API
    await LoadDataAsync();
}

protected override void OnParametersSet()
{
    // Quando cambiano i parametri
}
```

## 📄 Pagine di Esempio

Il progetto include diverse pagine educative:

### 1. **Index** (`/`)
Homepage con introduzione e panoramica del progetto.

### 2. **Dashboard** (`/dashboard`)
Esempio di dashboard con:
- Card statistiche
- Grafici (simulati con progress bar)
- Lista attività recenti
- Tabella prodotti top

### 3. **Buttons** (`/buttons`)
Tutti i tipi di bottoni MudBlazor:
- Varianti (Filled, Outlined, Text)
- Colori
- Dimensioni
- Icon buttons
- FAB (Floating Action Button)
- Button groups

### 4. **Typography** (`/typography`)
Sistema di tipografia completo:
- Headings (h1-h6)
- Body text
- Colori del testo
- Allineamento

### 5. **Cards** (`/cards`)
Esempi di card:
- Card base
- Con header e avatar
- Con immagini
- Con azioni
- Elevation e varianti

### 6. **Forms** (`/forms`)
Tutti i componenti di input:
- Text fields
- Numeric fields
- Select e multi-select
- Checkbox e switch
- Radio buttons
- Date e time picker
- Slider e rating

### 7. **Validation** (`/validation`)
Form con validazione usando DataAnnotations:
- Campi required
- Validazione email
- StringLength
- Range
- Compare (per conferma password)
- Messaggi di errore personalizzati

### 8. **Tables** (`/tables`)
Tabelle interattive:
- Tabella base
- Con sorting
- Con paginazione
- Con azioni per riga
- SimpleTable (più leggera)

### 9. **Dialogs** (`/dialogs`)
Finestre di dialogo:
- Dialog semplice
- Alert dialog
- Confirmation dialog
- Delete confirmation
- Dialog con form
- Full screen dialog

### 10. **Snackbars** (`/snackbars`)
Notifiche temporanee:
- Livelli di severity (Info, Success, Warning, Error)
- Con azioni
- Durata personalizzata
- Diverse posizioni

### 11. **Students** (`/students`) ⭐
**CRUD completo** per gestione studenti:
- **Create**: Aggiungi nuovi studenti
- **Read**: Visualizza lista e dettagli
- **Update**: Modifica studenti esistenti
- **Delete**: Elimina studenti
- Ricerca e filtri
- Statistiche

## 🎓 CRUD Completo

Il progetto include un esempio completo di CRUD nella pagina `/students`.

### Architettura

```
Pages/Students.razor          → UI e logica presentazione
    ↓
Services/StudentService.cs    → Business logic
    ↓
Models/Student.cs             → Data model
```

### Funzionalità

1. **Lista Studenti**
   - Visualizzazione in tabella
   - Sorting
   - Paginazione
   - Ricerca per nome/email
   - Filtro per corso

2. **Aggiungi Studente**
   - Dialog con form validato
   - Campi: Nome, Cognome, Email, Età, Corso
   - Validazione in tempo reale
   - Feedback con snackbar

3. **Modifica Studente**
   - Dialog pre-popolato con dati esistenti
   - Possibilità di attivare/disattivare
   - Validazione

4. **Visualizza Dettagli**
   - Dialog di sola lettura
   - Visualizzazione completa dati
   - UI pulita e organizzata

5. **Elimina Studente**
   - Confirmation dialog
   - Messaggio di conferma
   - Feedback con snackbar

### StudentService

Il servizio gestisce i dati (in memoria per questo esempio):

```csharp
public class StudentService
{
    // CRUD operations
    Task<List<Student>> GetAllAsync()
    Task<Student?> GetByIdAsync(int id)
    Task<Student> AddAsync(Student student)
    Task<Student?> UpdateAsync(Student student)
    Task<bool> DeleteAsync(int id)

    // Query personalizzate
    Task<List<Student>> SearchByNameAsync(string searchTerm)
    Task<List<Student>> GetByCourseAsync(string course)
}
```

**Nota**: In un'app reale, questo servizio comunicheremità con un database (Entity Framework Core) o una API REST.

## 🎯 Best Practices

### 1. Naming Conventions

```csharp
// Pascal Case per classi, metodi, proprietà pubbliche
public class StudentService
{
    public string FirstName { get; set; }
    public void GetAllStudents() { }
}

// Camel case per variabili private e parametri
private string _firstName;
public void DoSomething(string firstName) { }

// Underscore per campi privati
private readonly IService _service;
```

### 2. Async/Await

Usa sempre `async/await` per operazioni I/O:

```csharp
// ✅ Corretto
protected override async Task OnInitializedAsync()
{
    _students = await StudentService.GetAllAsync();
}

// ❌ Evita
protected override void OnInitialized()
{
    _students = StudentService.GetAllAsync().Result; // Può causare deadlock
}
```

### 3. Null Safety

Con C# 12 e nullable reference types:

```csharp
// ✅ Nullable esplicito
public string? Name { get; set; }  // Può essere null

// ✅ Non nullable con default
public string Name { get; set; } = "";  // Non sarà mai null

// ✅ Check null-safe
if (student?.Name?.Length > 0) { }

// ✅ Null coalescing
var name = student?.Name ?? "Unknown";
```

### 4. Dependency Injection

```csharp
// ✅ Usa constructor injection nei servizi
public class StudentService
{
    private readonly IDbContext _db;

    public StudentService(IDbContext db)
    {
        _db = db;
    }
}

// ✅ Usa @inject nei componenti Razor
@inject StudentService StudentService
@inject ISnackbar Snackbar
```

### 5. Form Validation

```csharp
// ✅ Usa DataAnnotations
public class Student
{
    [Required(ErrorMessage = "Nome obbligatorio")]
    [StringLength(50, MinimumLength = 2)]
    public string FirstName { get; set; } = "";
}

// ✅ Valida prima di salvare
private async Task Submit()
{
    await _form!.Validate();

    if (_form.IsValid)
    {
        await StudentService.AddAsync(_student);
    }
}
```

## 📚 Risorse Aggiuntive

### Documentazione Ufficiale

- **[Blazor Docs](https://learn.microsoft.com/aspnet/core/blazor/)** - Documentazione ufficiale Microsoft
- **[MudBlazor Docs](https://mudblazor.com/)** - Tutti i componenti MudBlazor
- **[C# Guide](https://learn.microsoft.com/dotnet/csharp/)** - Guida completa al linguaggio C#

### Tutorial e Corsi

- **[Microsoft Learn - Blazor](https://learn.microsoft.com/training/paths/build-web-apps-with-blazor/)** - Percorso gratuito Microsoft
- **[MudBlazor University](https://mudblazor.com/mud/project/blazor/overview)** - Tutorial MudBlazor
- **[Blazor School](https://blazorschool.com/)** - Tutorial e ricette

### Community

- **[Blazor GitHub](https://github.com/dotnet/aspnetcore/tree/main/src/Components)** - Codice sorgente Blazor
- **[MudBlazor GitHub](https://github.com/MudBlazor/MudBlazor)** - Codice sorgente MudBlazor
- **[Stack Overflow - Blazor](https://stackoverflow.com/questions/tagged/blazor)** - Q&A community

### Esempi e Template

- **[Awesome Blazor](https://github.com/AdrienTorris/awesome-blazor)** - Lista curata di risorse Blazor
- **[MudBlazor Templates](https://github.com/MudBlazor/Templates)** - Template pronti all'uso

## 🤝 Contribuire

Questo è un progetto didattico. Sentiti libero di:
- Segnalare errori
- Proporre miglioramenti
- Aggiungere nuovi esempi
- Migliorare la documentazione

## 📝 Note per lo Studio

### Percorso Consigliato

1. **Giorno 1-2**: Esplora i componenti base
   - Index, Buttons, Typography, Cards
   - Comprendi la sintassi Razor e C#

2. **Giorno 3-4**: Form e validazione
   - Forms, Validation
   - Impara DataAnnotations e data binding

3. **Giorno 5-6**: Tabelle e interazioni
   - Tables, Dialogs, Snackbars
   - Comprendi il flusso di interazione

4. **Giorno 7-10**: CRUD completo
   - Students (CRUD)
   - Studia l'architettura completa
   - Prova a creare il tuo CRUD

### Esercizi Suggeriti

1. **Crea un CRUD per "Libri"**
   - Campi: Titolo, Autore, ISBN, Anno, Genere
   - Aggiungi filtro per genere
   - Aggiungi ricerca per autore

2. **Crea una Dashboard personalizzata**
   - Card con statistiche a tua scelta
   - Grafico (puoi usare una libreria come ApexCharts)
   - Lista attività

3. **Estendi il form di validazione**
   - Aggiungi validazione personalizzata
   - Crea un custom validator
   - Aggiungi conferma password con regex

## 🎉 Buono Studio!

Questo progetto è stato creato per aiutarti a imparare rapidamente. Prenditi il tempo necessario per esplorare ogni sezione, modificare il codice e sperimentare. La pratica è fondamentale!

**Suggerimento**: Apri questo progetto in Visual Studio e usa il debugger (F5) per capire come funziona il codice passo dopo passo.

---

**Happy Coding! 🚀**
