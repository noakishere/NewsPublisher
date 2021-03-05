# NewsPublisher

1.	Problem description:
In this exercise we will design and implement interaction between different entities.
We are assuming we have two main entities and implementing their fields and methods that support their interaction. 
Suppose we have a NewsPublisher that produces news data through a publish action; and we have one or many NewsReader that subscribe to the NewsPublisher, and need to be notified whenever a news article is published. A NewsReader is notified of a new article through the action readNews. Check the image below.

a.	A NewsPublisher must be able to Register a NewsReader (that wants to get notified).

b.	A NewsPublisher must be able to UnRegister a NewsReader (that does Not want to get notified).

c.	A NewsPublisher is updated through a method that it must implement called setNewsArticle that takes a news article as a parameter. The news article data is just a string of the following format: [news article number - news article text] for example: “123 - this is a news article text”.

d.	The setNewsArticle method is the first method to be called and it triggers the notification process.

e.	A NewsPublisher notifies every subscribed NewsReader that a news is published.

f.	A NewsPublisher also prints to the output window the statement: 
“NewsPublisher : A new Article is Published” when it publishes an article

g.	A NewsReader must support the ReadNews action where it prints a statement saying that it read the news, the statement is of the following format: “NewsReader [NewsReader Number] read the news: [news article number - news article text]”

Questions:
1.	Develop a UML Class diagram that represents the interfaces, classes, methods and associations between Classes.
2.	Develop a UML Sequence diagram that represents the method calls between objects.
3.	Implement the UML design into a C# program and write a client class to test the implemented code.


