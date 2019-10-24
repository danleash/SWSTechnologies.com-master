using System;
using Xunit;
using SWSTechnologies1.Models;
using SWSTechnologies1.Controllers;
using Moq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Linq;

namespace SWSTechnologies1.Tests
{
    public class UnitTest1
    {
        //[Fact]
        //public void ContactClientTest() {
            
        //    Mock<IContactRepository> mock = new Mock<IContactRepository>();
        //    mock.Setup(m => m.Contact).Returns((new ContactClientModel[] {
        //new ContactClientModel { Name = "Dan Leash", EmailAddress = "DAN.LEASH@GMAIL.COM", PhoneNumber = "856-536-2237", Message = "Microsoft pls give me job" },
        //   new ContactClientModel { Name = "Dan Leash", EmailAddress = "DAN.LEASH@GMAiIL.COM", PhoneNumber = "836-536-2237", Message = "Micrsoft pls give me job"},
        //    new ContactClientModel { Name = "Dan Leash", EmailAddress = "DAN.LEASH@GMAIL.COM", PhoneNumber = "856-536-2237", Message = "Microsoft pls give me job" }
        //}).AsQueryable<ContactClientModel>());
        //    ContactController controller = new ContactController(mock.Object);
        //    ContactClientModel[] result =
        //(controller.Create() as ContactClientModel)
        //    .Contact.ToArray();
        //    ContactClientModel[] contArray = result;
        //    Assert.True(contArray.Length == 3);
        //    Assert.Equal("Dan Leash", contArray[0].Name);
        //    Assert.Equal("Dan Leash", contArray[1].Name);
        //    Assert.Equal("Dan Leash", contArray[2].Name);
        //}
    
    }
}
