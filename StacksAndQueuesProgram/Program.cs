using StacksAndQueues;

////Performing of stack operations
//LinkedListStack List=new LinkedListStack();
//List.push(70);
//List.push(30);
//List.push(56);
//List.Display();

//Performing of peek and pop operations
//AbilityToPeakAndPop AbilityToPeakAndPop=new AbilityToPeakAndPop();
//AbilityToPeakAndPop.push(70);
//AbilityToPeakAndPop.push(30);
//AbilityToPeakAndPop.push(56);
//AbilityToPeakAndPop.Display();
//AbilityToPeakAndPop.peek();
//AbilityToPeakAndPop.pop();
//AbilityToPeakAndPop.IsEmpty();
//AbilityToPeakAndPop.Display();

//Performing Enqueue Operations
//LinkedListEnqueue enqueue= new LinkedListEnqueue();
//enqueue.Enqueue(56);
//enqueue.Enqueue(30);
//enqueue.Enqueue(70);
//enqueue.Display();

//Performing Dequeue Operations
LinkedListDequeue dequeue= new LinkedListDequeue();
dequeue.Enqueue(56);
dequeue.Enqueue(30);
dequeue.Enqueue(70);
dequeue.Dequeue(56);
dequeue.Dequeue(30);
dequeue.Dequeue(70);
dequeue.Display();