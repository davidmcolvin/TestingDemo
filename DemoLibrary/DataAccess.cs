﻿using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public static class DataAccess
  {
    private static string personTextFile = "PersonText.txt";

    public static void AddNewPerson(PersonModel person)
    {
      List<PersonModel> people = GetAllPeople();

      AddPersonToPeopleList(people, person);

      List<string> lines = ConvertModelsToCSV(people);

      File.WriteAllLines(personTextFile, lines);
    }

    public static void AddPersonToPeopleList(List<PersonModel> people, PersonModel person)
    {
      if (string.IsNullOrWhiteSpace(person.FirstName))
      {
        throw new ArgumentException("Bad parameter", "FirstName");
      }

      if (string.IsNullOrWhiteSpace(person.LastName))
      {
        throw new ArgumentException("Bad parameter", "LastName");
      }

      people.Add(person);
    }

    public static List<string> ConvertModelsToCSV(List<PersonModel> people)
    {
      List<string> output = new List<string>();

      foreach (PersonModel personModel in people)
      {
        output.Add($"{personModel.FirstName},{personModel.LastName}");
      }

      return output;
    }

    public static List<PersonModel> GetAllPeople()
    {
      List<PersonModel> output = new List<PersonModel>();
      string[] content = File.ReadAllLines(personTextFile);

      foreach (string line in content)
      {
        string[] data = line.Split(',');
        output.Add(new PersonModel { FirstName = data[0], LastName = data[1] });
      }

      return output;
    }
  }
}
