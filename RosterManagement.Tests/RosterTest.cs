using System;
using Xunit;

namespace RosterManagement.Tests
{
    public class RosterTest
    {
        [Fact]
        public void AddingAStudentAddsItToTheStudentRoster()
        {
            var school = new CodeSchool();
            school.Add("Aimee", 2);

            var actual = school.Roster();

            var expected = new[] { "Aimee" };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddingMoreStudentsAddsThemToTheStudentRoster()
        {
            var school = new CodeSchool();
            school.Add("Blair", 2);
            school.Add("James", 2);
            school.Add("Paul", 2);
        
            var actual = school.Roster();

            var expected = new[] { "Blair", "James", "Paul" };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddingStudentsToDiffWavesAddsThemToSameRoster()
        {
            var school = new CodeSchool();
            school.Add("Chelsea", 3);
            school.Add("Logan", 7);

            var actual = school.Roster();

            var expected = new[] { "Chelsea", "Logan"};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WaveReturnsTheStudentsInThatWaveInAlphabeticalOrder()
        {
            var school = new CodeSchool();
            school.Add("Franklin", 5);
            school.Add("Bradley", 5);
            school.Add("Jeff", 1);
            
            var actual = school.Grade(5);

            var expected = new[] { "Bradley", "Franklin" };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WaveReturnsAnEmptyListIfThereAreNoStudentsInThatWave()
        {
            var school = new CodeSchool();

            var actual = school.Grade(1); 

            Assert.Empty(actual);
        }

        [Fact]
        public void StudentNamesWithWavesAreDisplayedInTheSameSortedRoster()
        {
            var school = new CodeSchool();
            school.Add("Peter", 2);
            school.Add("Anna", 1);
            school.Add("Barb", 1);
            school.Add("Zoe", 2);
            school.Add("Alex", 2);
            school.Add("Jim", 3);
            school.Add("Charlie", 1);
                
            var actual = school.Roster();
            
            var expected = new[] { "Anna", "Barb", "Charlie", "Alex", "Peter", "Zoe", "Jim" };
            Assert.Equal(expected, actual);
        }
    }
}
