

using ConcurrencySample;

//ExceptionInThread sample = new ExceptionInThread();  
//sample.StartWithExceptionHandling();
//Console.ReadKey();


//CountiutionSample sample = new CountiutionSample();

//sample.Start2(); 

//AsyncsSamples sample = new AsyncsSamples();

//sample.DisplayPrimeNumeV1();

// this async programmig work like sync progaramming
AsyncsSamples sample = new AsyncsSamples();

await sample.Print("hello");
await sample.Print("world");
await sample.Print("sajjad");
await sample.Print("boskabadi");


// this is paraler programmig

await sample.Print("hello");
await sample.Print("world");
await sample.Print("sajjad");
await sample.Print("boskabadi");

