using System;
using System.Collections.Generic;
using System.Linq;
class StringProcessor{
 public static List<string> FilterStrings(List<string> strings, int minLength){
  return strings.Where(s => s.Length >= minLength).ToList();
 }
 public static Dictionary<char, int> CountCharacterOccurrences(string input){
  return input.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
 }
 public static string ReverseString(string input){
  char[] charArray = input.ToCharArray();
  Array.Reverse(charArray);
  return new string(charArray);
 }
 public static string JoinStrings(List<string> strings, char separator){
  return string.Join(separator, strings);
 }
 public static void Main(){
  List<string> testStrings = new List<string>{"apple", "banana", "cherry", "date", "fig", "grape"};
  var filtered = FilterStrings(testStrings, 5);
  Console.WriteLine("Filtered Strings: " + JoinStrings(filtered, ', '));
  string example = "hello world";
  var occurrences = CountCharacterOccurrences(example);
  foreach(var kvp in occurrences){
   Console.WriteLine(kvp.Key + ": " + kvp.Value);
  }
  string reversed = ReverseString(example);
  Console.WriteLine("Reversed String: " + reversed);
 }
}
