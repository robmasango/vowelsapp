using System;
using VowelsAppExtensions;
using Xunit;

namespace VowelsAppUnitTests
{
    public class TestProjectMethods
    {
        private readonly RunApp runApp = new RunApp();
        private readonly HelperMethods helperMethods = new HelperMethods();

        //Test ExecuteApplication
        [Fact]
        public void Ensure_when_1_is_pressed_runs_correct_method()
        {
            string operation = "1";
            string str = "I like eating apples";

            var record = runApp.ExecuteApplication(operation, str);

            bool result;
            if (record == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.True(result, "1 should execute Checkduplicates method");
        }

        [Fact]
        public void Ensure_when_1_is_not_pressed_runs_incorrect_method()
        {
            string operation = "5";
            string str = "I like eating apples";

            var record = runApp.ExecuteApplication(operation, str);

            bool result;
            if (record == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.False(result, "1 was not pressed incorrect or no method executed");
        }




        [Fact]
        public void Ensure_when_2_is_pressed_runs_correct_method()
        {
            string operation = "2";
            string str = "I like eating apples";

            var record = runApp.ExecuteApplication(operation, str);

            bool result;
            if (record == 2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.True(result, "2 should execute GetUniqueVowels method");
        }

        [Fact]
        public void Ensure_when_2_is_not_pressed_runs_incorrect_method()
        {
            string operation = "5";
            string str = "I like eating apples";

            var record = runApp.ExecuteApplication(operation, str);

            bool result;
            if (record == 3)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.False(result, "2 was not pressed incorrect or no method executed");
        }

        [Fact]
        public void Ensure_when_3_is_pressed_runs_correct_method()
        {
            string operation = "3";
            string str = "I like eating apples";

            var record = runApp.ExecuteApplication(operation, str);

            bool result;
            if (record == 3)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.True(result, "3 should execute UniqueVowelsAndNonVowels method");
        }

        [Fact]
        public void Ensure_when_3_is_not_pressed_runs_incorrect_method()
        {
            string operation = "5";
            string str = "I like eating apples";

            var record = runApp.ExecuteApplication(operation, str);

            bool result;
            if (record == 3)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.False(result, "3 was not pressed incorrect or no method executed");
        }



        [Fact]
        public void Ensure_duplicate_check_for_I_like_eating_apples_equals_ileap()
        {
            //arrange
            string str = "I like eating apples";

            //act
            var record = helperMethods.Checkduplicates(str);
            var finalString = new string(record.ToArray());

            //assert
            Assert.Contains(finalString, "ileap");
        }

        [Fact]
        public void Ensure_duplicate_check_for_abcd4_equals_empty_string()
        {
            //arrange
            string str = "abcd4";

            //act
            var record = helperMethods.Checkduplicates(str);
            var finalString = new string(record.ToArray());

            //assert
            Assert.Contains(finalString, "");
        }

        [Fact]
        public void Ensure_unique_vowel_count_for_I_like_eating_apples_equals_3()
        {
            //arrange
            string str = "I like eating apples";

            //act
            var record = helperMethods.GetUniqueVowels(str);

            //assert
            Assert.Equal(3, record);
        }

        [Fact]
        public void Ensure_unique_vowel_count_for_jkl_kkjh_equals_0()
        {
            //arrange
            string str = "jkl kkjh";

            //act
            var record = helperMethods.GetUniqueVowels(str);

            //assert
            Assert.Equal(0, record);
        }

        [Fact]
        public void Ensure_vowels_vs_nonvowels_count_for_I_eat_equals_vowels_are_more_than_nonvowels()
        {
            //arrange
            string str = "I eat";

            //act
            int vowels = helperMethods.CountUniqueVowelsAndNonVowel(str).Item1;
            int nonvowels = helperMethods.CountUniqueVowelsAndNonVowel(str).Item2;

            bool result;
            if (vowels > nonvowels)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            //assert
            Assert.True(result, "The text has more vowels than non vowels");
        }

        [Fact]
        public void Ensure_vowels_vs_nonvowels_count_for_that_dog_equals_nonvowels_are_more_than_vowels()
        {
            //arrange
            string str = "that dog";

            //act
            int vowels = helperMethods.CountUniqueVowelsAndNonVowel(str).Item1;
            int nonvowels = helperMethods.CountUniqueVowelsAndNonVowel(str).Item2;

            bool result;
            if (vowels < nonvowels)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            //assert
            Assert.True(result, "The text has more non vowels than vowels");
        }

        [Fact]
        public void Ensure_vowels_vs_nonvowels_count_for_3_a_equals_nonvowels_are_more_than_vowels()
        {
            //arrange
            string str = "3 a";

            //act
            int vowels = helperMethods.CountUniqueVowelsAndNonVowel(str).Item1;
            int nonvowels = helperMethods.CountUniqueVowelsAndNonVowel(str).Item2;

            bool result;
            if (vowels == nonvowels)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            //assert
            Assert.True(result, "The text has an equal amount of vowels and non vowels");
        }

    }

}

