using System;
using CSharpKoans.Core;
using NUnit.Framework;

namespace CSharpKoans
{
    public class AboutClasses : KoanContainer
    {
        public class Megalomaniac
        {
            private int planStep = 0;
            public string Name {  get; set;}
            public string Henchman { get; set; }
            public string Mission { get; set; }

            public void MakePlan(String plan)
            {
                Mission = plan;
            }

            internal void RetrieveNextStepOfPlan()
            {
                planStep++;
                switch (planStep) {
                    case 1:
                        Mission = "Steal the batmobile";
                        break;
                    case 2:
                        Mission = "Drive batmobile to Central Park";
                        break;
                    case 3:
                        Mission = "Cause accident involving catwoman";
                        break;
                    case 4:
                        Mission = "Escape from Central Park";
                        break;
                    case 5:
                        Mission = "Convince Batman he harmed Catwoman";
                        break;
                    case 6:
                        Mission = "Get Batman to reveal his secret identity";
                        break;
                    case 7:
                        Mission = "Put Bruce Wayne in Jail";
                        break;
                    default:
                        break;
                }

                
            }
        }

        const string FILL_ME_IN = "";

        [Koan]
        public void ClassTypesAreCopiedByReference()
        {
            var TheBrain = new Megalomaniac
            {
                Name = "The Brain",
                Henchman = "Pinky",
                Mission = "Try to take over the world."
            };
           
            var AnotherBrain = TheBrain;
            AnotherBrain.Mission = "The same thing we do every night";

            Assert.AreEqual(TheBrain.Mission, AnotherBrain.Mission);
        }

        [Koan]
        public void ClassMethodsCanDefineDifferentAccess()
        {
            var Joker = new Megalomaniac();

            // Uncomment the next line and make the assert pass:
            Joker.MakePlan("Destroy Batman");

            Assert.AreEqual("Destroy Batman", Joker.Mission);

        }

        [Koan]
        public void PublicMethodsCanChangeObjectState()
        {
            var Joker = new Megalomaniac();

            // Uncomment the next line and make the asert pass:
            Joker.MakePlan("Destroy Batman");

            Assert.AreEqual("Destroy Batman", Joker.Mission);
            Joker.RetrieveNextStepOfPlan();
            Assert.AreEqual("Steal the batmobile", Joker.Mission);

        }

        [Koan]
        public void ClassesCanMaintainInternalState()
        {
            var Joker = new Megalomaniac();

            //Uncomment the next line and make the assert pass:
            Joker.MakePlan("Destroy Batman");

            Assert.AreEqual("Destroy Batman", Joker.Mission);
            Joker.RetrieveNextStepOfPlan();
            Assert.AreEqual("Steal the batmobile", Joker.Mission);
            Joker.RetrieveNextStepOfPlan();
            Assert.AreEqual("Drive batmobile to Central Park", Joker.Mission);
            Joker.RetrieveNextStepOfPlan();
            Assert.AreEqual("Cause accident involving catwoman", Joker.Mission);
            Joker.RetrieveNextStepOfPlan();
            Assert.AreEqual("Escape from Central Park", Joker.Mission);
            Joker.RetrieveNextStepOfPlan();
            Assert.AreEqual("Convince Batman he harmed Catwoman", Joker.Mission);
            Joker.RetrieveNextStepOfPlan();
            Assert.AreEqual("Get Batman to reveal his secret identity", Joker.Mission);
            Joker.RetrieveNextStepOfPlan();
            Assert.AreEqual("Put Bruce Wayne in Jail", Joker.Mission);

        }


    }
}