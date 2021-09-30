using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {

    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("test artist");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Artist";
      Artist newArtist = new Artist(name);

      //Act
      string result = newArtist.ArtistName;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsArtistId_Int()
    {
      //Arrange
      string name = "Test Artist";
      Artist newArtist = new Artist(name);

      //Act
      int result = newArtist.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllArtistObjects_ArtistList()
    {
      //Arrange
      string name01 = "bob";
      string name02 = "joe";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };

      //Act
      List<Artist> result = Artist.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectArtist_Artist()
    {
      //Arrange
      string name01 = "bob";
      string name02 = "joe";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);

      //Act
      Artist result = Artist.Find(2);

      //Assert
      Assert.AreEqual(newArtist2, result);
    }

    [TestMethod]
    public void AddRecord_AssociatesRecordWithArtist_RecordList()
    {
      //Arrange
      string description = "Silence at Sunset";
      int year = 1555;
      Record newRecord = new Record(description, year);
      List<Record> newList = new List<Record> { newRecord };
      string name = "Jimmy";
      Artist newArtist = new Artist(name);
      newArtist.AddRecord(newRecord);

      //Act
      List<Record> result = newArtist.Records;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
  }
}