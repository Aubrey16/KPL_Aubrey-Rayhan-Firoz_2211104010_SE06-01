using System;
using System.Collections.Generic;

// Interface untuk Observer
public interface IObserver
{
    void Update(ISubject subject);
}

// Interface untuk Subject (Publisher)
public interface ISubject
{
    void Attach(IObserver observer);   // Menambahkan observer
    void Detach(IObserver observer);   // Menghapus observer
    void Notify();                     // Memberi tahu semua observer
}

// Implementasi Subject
public class Subject : ISubject
{
    public int State { get; set; } = 0; // Data/state yang diamati

    private List<IObserver> _observers = new List<IObserver>(); // Daftar observer

    // Menambahkan observer ke dalam list
    public void Attach(IObserver observer)
    {
        Console.WriteLine("Subject: Attached an observer.");
        this._observers.Add(observer);
    }

    // Menghapus observer dari list
    public void Detach(IObserver observer)
    {
        this._observers.Remove(observer);
        Console.WriteLine("Subject: Detached an observer.");
    }

    // Memberi tahu semua observer
    public void Notify()
    {
        Console.WriteLine("Subject: Notifying observers...");

        foreach (var observer in _observers)
        {
            observer.Update(this); // Memanggil Update() milik observer
        }
    }

    // Contoh perubahan state, dan langsung notify observer
    public void SomeBusinessLogic()
    {
        Console.WriteLine("\nSubject: I'm doing something important.");
        this.State = new Random().Next(0, 10); // Ubah nilai state
        Console.WriteLine("Subject: My state has just changed to: " + this.State);
        this.Notify(); // Panggil semua observer
    }
}

// Observer konkrit A
class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject).State < 3)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}

// Observer konkrit B
class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject).State == 0 || (subject as Subject).State >= 5)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}

// Kode utama (Main)
class Program
{
    static void Main(string[] args)
    {
        var subject = new Subject(); // Buat subject baru

        var observerA = new ConcreteObserverA(); // Buat observer A
        subject.Attach(observerA);               // Pasang observer A

        var observerB = new ConcreteObserverB(); // Buat observer B
        subject.Attach(observerB);               // Pasang observer B

        subject.SomeBusinessLogic();             // Subject berubah dan notify observer

        subject.Detach(observerB);               // Lepas observer B

        subject.SomeBusinessLogic();             // Subject berubah lagi, hanya A bereaksi
    }
}
