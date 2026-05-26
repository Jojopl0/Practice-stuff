public interface IShape {
    IShape Clone();
}

public class Rectangle : IShape {
    private int width;
    private int height;

    public Rectangle(int width, int height) {
        this.width = width;
        this.height = height;
    }

    public int GetWidth() {
        return this.width;
    }

    public int GetHeight() {
        return this.height;
    }

    public IShape Clone() {
        Rectangle clone = new Rectangle(this.width, this.height);
        return clone;
    }
}

public class Square : IShape {
    private int length;

    public Square(int length) {
        this.length = length;
    }

    public int GetLength() {
        return this.length;
    }

    public IShape Clone() {
       Square clone = new Square(this.length);
       return clone;
    }
}

public class Test {
    public List<IShape> CloneShapes(List<IShape> shapes) {
        List<IShape> cloned = new List<IShape>();
        foreach (var shape in shapes) {
                var tempCopy = shape.Clone();
                cloned.Add(tempCopy);
        }
        return cloned;
    }
}
