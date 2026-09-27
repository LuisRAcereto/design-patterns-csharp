// The visitor interface, one Visit overload per concrete element.
public interface IVisitor
{
    void Visit(Book book);
    void Visit(Electronic electronic);
}

