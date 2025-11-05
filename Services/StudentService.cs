using MudBlazorLearning.Models;

namespace MudBlazorLearning.Services;

/// <summary>
/// Servizio per gestire gli studenti - simile a un Service/Repository in Java/Spring
/// In un'app reale, questo comunicherebbe con un database o API
/// </summary>
public class StudentService
{
    // Simula un database in memoria (come una lista statica)
    private readonly List<Student> _students = new();
    private int _nextId = 1;

    public StudentService()
    {
        // Dati di esempio iniziali (seed data)
        SeedData();
    }

    /// <summary>
    /// Ottieni tutti gli studenti - simile a findAll() in JPA
    /// </summary>
    public Task<List<Student>> GetAllAsync()
    {
        // In C#, Task è simile a CompletableFuture in Java
        return Task.FromResult(_students.ToList());
    }

    /// <summary>
    /// Ottieni studente per ID - simile a findById() in JPA
    /// </summary>
    public Task<Student?> GetByIdAsync(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);
        return Task.FromResult(student);
    }

    /// <summary>
    /// Aggiungi nuovo studente - simile a save() in JPA
    /// </summary>
    public Task<Student> AddAsync(Student student)
    {
        student.Id = _nextId++;
        student.EnrollmentDate = DateTime.Now;
        _students.Add(student);
        return Task.FromResult(student);
    }

    /// <summary>
    /// Aggiorna studente esistente - simile a save() in JPA
    /// </summary>
    public Task<Student?> UpdateAsync(Student student)
    {
        var existingStudent = _students.FirstOrDefault(s => s.Id == student.Id);
        if (existingStudent == null)
        {
            return Task.FromResult<Student?>(null);
        }

        // Aggiorna le proprietà
        existingStudent.FirstName = student.FirstName;
        existingStudent.LastName = student.LastName;
        existingStudent.Email = student.Email;
        existingStudent.Age = student.Age;
        existingStudent.Course = student.Course;
        existingStudent.IsActive = student.IsActive;

        return Task.FromResult<Student?>(existingStudent);
    }

    /// <summary>
    /// Elimina studente - simile a deleteById() in JPA
    /// </summary>
    public Task<bool> DeleteAsync(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
            return Task.FromResult(false);
        }

        _students.Remove(student);
        return Task.FromResult(true);
    }

    /// <summary>
    /// Cerca studenti per nome - esempio di query personalizzata
    /// </summary>
    public Task<List<Student>> SearchByNameAsync(string searchTerm)
    {
        var results = _students
            .Where(s =>
                s.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                s.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return Task.FromResult(results);
    }

    /// <summary>
    /// Filtra studenti per corso
    /// </summary>
    public Task<List<Student>> GetByCourseAsync(string course)
    {
        var results = _students
            .Where(s => s.Course.Equals(course, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return Task.FromResult(results);
    }

    /// <summary>
    /// Dati iniziali per test
    /// </summary>
    private void SeedData()
    {
        var initialStudents = new List<Student>
        {
            new Student
            {
                Id = _nextId++,
                FirstName = "Mario",
                LastName = "Rossi",
                Email = "mario.rossi@university.it",
                Age = 20,
                Course = "Informatica",
                EnrollmentDate = DateTime.Now.AddMonths(-6),
                IsActive = true
            },
            new Student
            {
                Id = _nextId++,
                FirstName = "Giulia",
                LastName = "Bianchi",
                Email = "giulia.bianchi@university.it",
                Age = 22,
                Course = "Ingegneria",
                EnrollmentDate = DateTime.Now.AddMonths(-12),
                IsActive = true
            },
            new Student
            {
                Id = _nextId++,
                FirstName = "Luca",
                LastName = "Verdi",
                Email = "luca.verdi@university.it",
                Age = 19,
                Course = "Matematica",
                EnrollmentDate = DateTime.Now.AddMonths(-3),
                IsActive = true
            },
            new Student
            {
                Id = _nextId++,
                FirstName = "Anna",
                LastName = "Neri",
                Email = "anna.neri@university.it",
                Age = 21,
                Course = "Informatica",
                EnrollmentDate = DateTime.Now.AddMonths(-8),
                IsActive = false
            },
            new Student
            {
                Id = _nextId++,
                FirstName = "Paolo",
                LastName = "Gialli",
                Email = "paolo.gialli@university.it",
                Age = 23,
                Course = "Fisica",
                EnrollmentDate = DateTime.Now.AddMonths(-18),
                IsActive = true
            }
        };

        _students.AddRange(initialStudents);
    }
}
