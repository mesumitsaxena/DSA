// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
Class1 cl= new Class1();
//List<int> output= cl.solve(new List<int> { 186, 256, 102, 377, 186, 377 });
//int ans = cl.Bitonic(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11 },12);
//int ans = cl.divisors(33488383, 565, 29473);
//Permutationof2Strings bs = new Permutationof2Strings();
//List<List<int>> list = new List<List<int>>()
//{
//    new List<int> { 1, 3, 5 },
//    new List<int> { 2,6,9},
//    new List<int> { 3,6,9}
//};
////List<List<int>> ans = bs.threeSum(new List<int>() { 1, -4, 0, 0, 5, -5, 1, 0, -2, 4, -4, 1, -1, -4, 3, 4, -1, -1, -3 });
//int ans = bs.solve("abc", "abcbacabc");
//Node A = LinkedListOperations.insert_node(1, 6);
//Node B = LinkedListOperations.insert_node(2, 3);
//Node C = LinkedListOperations.insert_node(3, 7);
//Node D = LinkedListOperations.insert_node(4, 3);
//Node E = LinkedListOperations.insert_node(5, 6);
//PallindromLinkedList obj= new PallindromLinkedList();
//obj.lPalin(A);
//Node D = LinkedListOperations.reverseBetween(C, 2, 3);
//LRUCacheSolution lru = new LRUCacheSolution(7);
//lru.set(2, 1);
//lru.set(1, 10);
//lru.set(8, 13);
//Console.WriteLine(lru.get(12));
//lru.set(2, 8);
//Console.WriteLine(lru.get(11));
//Console.WriteLine(lru.get(7));
//lru.set(14, 7);
//lru.set(12, 9);
//lru.set(7, 10);
//Console.WriteLine(lru.get(11));
//lru.set(9, 3);
//lru.set(14, 15);
//Console.WriteLine(lru.get(15));
//lru.get(9);
//lru.set(4, 13);
//Console.WriteLine(lru.get(3));
//lru.set(13, 7);
//Console.WriteLine(lru.get(2));
//lru.set(5, 9);
//Console.WriteLine(lru.get(6));
//Console.WriteLine(lru.get(13));
//lru.set(4, 5);
//lru.set(3, 2);
//lru.set(4, 12);
//Console.WriteLine(lru.get(13));
//lru.get(7);
//lru.set(9, 7);
//Console.WriteLine(lru.get(3));
//Console.WriteLine(lru.get(6));
//Console.WriteLine(lru.get(2));
//SimplifyDirectoryPath simplifyDirectoryPath= new SimplifyDirectoryPath();
//string s = simplifyDirectoryPath.simplifyPath("/home//foo/");
Deque obj = new Deque();
obj.EnqueueRear(3);
Console.WriteLine("Rear"+obj.PeekRear());
Console.WriteLine("Front"+obj.PeekFront());
obj.EnqueueRear(5);
Console.WriteLine("Rear" + obj.PeekRear());
Console.WriteLine("Front" + obj.PeekFront());
obj.EnqueueFront(7);
Console.WriteLine("Rear" + obj.PeekRear());
Console.WriteLine("Front" + obj.PeekFront());
obj.DequeueRear();
Console.WriteLine("Rear" + obj.PeekRear());
Console.WriteLine("Front" + obj.PeekFront());
obj.DequeueFront();
Console.WriteLine("Rear" + obj.PeekRear());
Console.WriteLine("Front" + obj.PeekFront());
//Console.WriteLine(s);

