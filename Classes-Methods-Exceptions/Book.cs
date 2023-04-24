using System;

public class Book
{
	public string title;
	public string author;
	public string summary;
	public int pages;

	// constructor method - class definition, can add multiple constructors for flexibility
	public Book() { 
	}

	public Book(string aTitle, string aAuthor, string aSummary, int aPages)
	{
		Console.WriteLine("Creating Book...");
		this.title = aTitle;
		this.author = aAuthor;
		this.summary = aSummary;
		this.pages = aPages;
	}
}