

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

//var hello = sample.Print("hello");
//var world = sample.Print("world");
//var sajjad = sample.Print("sajjad");
//var boskabadi = sample.Print("boskabadi");

//await hello;
//await world;
//await sajjad;
//await boskabadi;


//CancellationTokenSource cts = new CancellationTokenSource();
var sample02 = new AsyncsSamples();

//var task = sample02.PrintAfter20Seconds("my message", cts.Token);

//Console.WriteLine("if you want cancel the task press c charcter");
//var res = Console.ReadLine();
//if(res == "c")
//{
//    cts.Cancel();   
//}

//try
//{
//    await task;
//}
//catch (TaskCanceledException ex)
//{
//    var status = task.Status;
//    var isCansled = task.IsCanceled;
//    Console.WriteLine($"status : {status} and IsCanceled : {isCansled}");
//    Console.WriteLine(ex.Message);
//}


var after3 = sample02.PrintAfter3();
var after4 = sample02.PrintAfter4();    
var after5 = sample02.PrintAfter5();

//await after3;
//await after4;
//await after5;

await Task.WhenAll(after3, after4, after5); 
