using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTests : IDisposable
  {

    public void Dispose()
    {
      Record.ClearAll();
    }

    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
      Record newRecord = new Record("test", 1234);
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "singing in the snow";

      //Act
      Record newRecord = new Record(description, 1944);
      string result = newRecord.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetYear_ReturnsYear_Int()
    {
      //Arrange
      int year = 1944;

      //Act
      Record newRecord = new Record("test", year);
      int result = newRecord.Year;

      //Assert
      Assert.AreEqual(year, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "worst song ever";
      Record newRecord = new Record(description, 1234);

      //Act
      string updatedDescription = "best song ever";
      newRecord.Description = updatedDescription;
      string result = newRecord.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void SetYear_SetYear_String()
    {
      //Arrange
      int year = 1990;
      Record newRecord = new Record("test", year);

      //Act
      int updatedYear = 2020;
      newRecord.Year = updatedYear;
      int result = newRecord.Year;

      //Assert
      Assert.AreEqual(updatedYear, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_RecordList()
    {
      // Arrange
      List<Record> newList = new List<Record> { };

      // Act
      List<Record> result = Record.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsRecords_RecordList()
    {
      //Arrange
      string description01 = "bobby";
      string description02 = "stan";
      int year01 = 1256;
      int year02 = 1848;
      Record newRecord1 = new Record(description01, year01);
      Record newRecord2 = new Record(description02, year02);
      List<Record> newList = new List<Record> { newRecord1, newRecord2 };

      //Act
      List<Record> result = Record.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}