namespace Palindromes.Models
{
  public class PalindromesChecker
  {
    public string UserInput {get; set;}

    public string IsPalindrome()
    {
      int i = 0;
      int j = UserInput.Length - 1;
      while(i < j)
      {
        if(UserInput[i] != UserInput[j])
        {
          return "This is not a palindrome";
        }
        i++;
        j--;
      }
      return "This is a palindrome";
    }

  }
}