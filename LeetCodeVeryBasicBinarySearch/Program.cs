// See https://aka.ms/new-console-template for more information

using LeetCodeVeryBasicBinarySearch;
Console.WriteLine("Hello, World!");

int[] testData = { 1, 0, 3, 5, 9, 12 };
int testTarget = 9;

SearchForTarget getTarget = new SearchForTarget();
Console.WriteLine(getTarget.search(testData, testTarget));