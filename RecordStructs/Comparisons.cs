using Xunit;

namespace RecordStructs;

internal class MyClass
{
    public int Id { get; set; }
}

internal struct MyStruct
{
    public int Id;
}

public partial class Comparisons
{
    [Fact]
    public void TwoIdenticalClasses_AreNotEqual()
    {
        var firstClass = new MyClass() { Id = 1 };
        var secondClass = new MyClass() { Id = 1 };

        Assert.NotEqual(firstClass, secondClass);
    }

    [Fact]
    public void TwoIdenticalStructs_AreEqual()
    {
        var firstRecord = new MyStruct();
        var secondRecord = new MyStruct();

        Assert.Equal(firstRecord, secondRecord);
    }
}

// Record behavior


internal record MyRecord
{
    public int Id { get; set; }
}

public partial class Comparisons
{

    // When records are used, the properties themselves are checked for comparison, not the reference. This is similar to a struct.

    [Fact]
    public void TwoIdenticalRecords_AreEqual()
    {
        var firstRecord = new MyRecord() { Id = 1 };
        var secondRecord = new MyRecord() { Id = 1 };

        Assert.Equal(firstRecord, secondRecord);
    }
}


// This is the explicit way to make a record class. By default all records are classes already though.
internal record class MyRecordClass
{
    public int Id { get; set; }
}

// You can now specify a record as a struct instead of a class.
internal record struct MyRecordStruct
{
    public int Id { get; set; }
}

public partial class Comparisons
{

    // Both record classes and record structs use the same comparison behaviors as structs.

    [Fact]
    public void TwoIdenticalRecordClasses_AreEqual()
    {
        var firstRecordClass = new MyRecordClass() { Id = 1 };
        var secondRecordClass = new MyRecordClass() { Id = 1 };

        Assert.Equal(firstRecordClass, secondRecordClass);
    }

    [Fact]
    public void TwoIdenticalRecordStructs_AreEqual()
    {
        var firstRecordStruct = new MyRecordStruct() { Id = 1 };
        var secondRecordStruct = new MyRecordStruct() { Id = 1 };

        Assert.Equal(firstRecordStruct, secondRecordStruct);
    }
}