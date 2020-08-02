using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Return.Controllers;
using Return.Models.Services;
using Return.Models.ViewModels;

namespace Return.UnitTests.Controllers
{
    class HomeControllerTests
    {
        private Mock<IReturnService> _mockReturnService;
        private HomeController _homeController;
        private ReturnViewModel _newReturn;

        private void Init()
        {
            _mockReturnService = new Mock<IReturnService>();
            _homeController = new HomeController(_mockReturnService.Object);

            _newReturn = new ReturnViewModel()
            {
                CustomerName = "Piotr",
                CustomerLastName = "Nowak",
            };
        }

        [Test]
        public void AddNewReturn_WhenReturnNull_ShouldReturnBadRequest()
        {
            Init();

            var result = _homeController.AddNewReturn(null);

            result.Should().BeOfType<BadRequestResult>();
        }

        [Test]
        public void AddNewReturn_WhenAddedNewReturn_ShouldReturnView()
        {
            Init();

            _mockReturnService.Setup(x => x.AddReturn(_newReturn)).Returns(_newReturn);

            var result = _homeController.AddNewReturn(_newReturn);

            result.Should().BeOfType<ViewResult>();
        }

        [Test]
        public void AddNewReturn_WhenAddedNewReturn_ShouldReturnNewReturn()
        {
            Init();

            _mockReturnService.Setup(x => x.AddReturn(_newReturn)).Returns(_newReturn);

            var result = _homeController.AddNewReturn(_newReturn);
            var output = (result as ViewResult).Model as ReturnViewModel;

            output.CustomerName.Should().Be("Piotr");
        }

        [Test]
        public void AddNewReturn_WhenResultIsNull_ShouldBadRequest()
        {
            Init();

            _mockReturnService.Setup(x => x.AddReturn(_newReturn)).Returns((ReturnViewModel)null);

            var result = _homeController.AddNewReturn(_newReturn);

            result.Should().BeOfType<BadRequestResult>();
        }
    }
}

