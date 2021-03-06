﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NUnit.Framework;
using Test.Data;
using Test.Domain.Models;

namespace test
{
    public class Class1
    {
        private PoInfo _poInfo;

        [SetUp]
        public void test()
        {
        }

        [TearDown]
        public void teardown()
        {
            //using (var context = new Context())
            //{
            //    context.PoInfos.Attach(_poInfo);
            //    context.PoInfos.Remove(_poInfo);
            //    context.SaveChanges();
            //}
        }

        [Test]
        public void load()
        {
            _poInfo = SetupPoObject();

            using (var context = new Context())
            {
                context.PoInfos.Add(_poInfo);
                context.SaveChanges();
            }

            List<PoInfo> poObject;

            using (var context = new Context())
            {
                context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                poObject = context.PoInfos.Include(x => x.LineItems).ToList();
            }

            Assert.That(poObject.Any(x => x.SenderId == _poInfo.SenderId));
            Assert.That(poObject.First(x => x.SenderId == _poInfo.SenderId).LineItems.Count, Is.EqualTo(1));
        }

        [Test]
        public void delete()
        {
            using (var context = new Context())
            {
                context.PoInfos.RemoveRange(context.PoInfos.Where(x => x.SenderId > 0));
                context.SaveChanges();
            }
        }

        [Test]
        public void join()
        {
            var testlist = new List<int>{20,1};
            System.Diagnostics.Debug.WriteLine($"{string.Join(", ", testlist)}");
        }

        private static PoInfo SetupPoObject()
        {
            return new PoInfo
            {
                Sidemark = "test",
                SenderId = new Random().Next(),
                Notes = "test",
                StAddress1 = "test",
                StCity = "test",
                StName = "test",
                StPhone = "test",
                StState = "test",
                StZip = "test",
                UnitType = 1,
                Po = "Po thingy",
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        Color = "test",
                        ControlType = "test",
                        HandSample = "test",
                        Height = 20,
                        Width = 20,
                        Model = "test",
                        Mount = "test",
                        Quantity = 20,
                        Sidemark = "test",
                        Sku = "test",
                        SpecialInstructions = "test"
                    }
                }
            };
        }
    }
}
