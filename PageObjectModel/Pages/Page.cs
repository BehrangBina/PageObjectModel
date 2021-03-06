﻿using OpenQA.Selenium.Support.PageObjects;
using PageObjectModel.Utils.Selenium;

namespace PageObjectModel.Pages
{
    /// <summary>
    /// this class is primarily created as a Inheritable class. An abstract class enables other classes to inherit from this class, 
    /// but forbids to instantiate. One can inherit from an abstract class but we cannot create objects of an abstract class. 
    /// Abstract class can have abstract as well as non abstract methods. Abstract methods are those which are not having method definition.
    /// The purpose of an abstract class is to provide
    /// a common definition of a base class that multiple derived classes can share
    /// </summary>
    /// <remarks>
    /// Many testers do following when they implement a page object model framework:
    /// 1. they create void methods in the class files in such cases when they should return a page type.
    /// 2. They instantiate multiple page classes in the step definition files to be able to access the methods located in such page classes.
    /// The problem with the first point is that no relationship among pages is created.
    /// And the problem with the second point is that the step definition files are inflated
    /// with unnecessary code and in many cases a lot casting errors occur.
    /// To avoid such problems, we are going to implement a generic method.
    ///</remarks>
    public abstract class Page
    {
        protected  T InstanceOf<T>() where T : BasePage, new()
        {
            var pageClass = new T {Driver = Driver.Browser()};
            // Avoid null refrence exception 
            PageFactory.InitElements(Driver.Browser(),pageClass);
            return pageClass;
        }
    }
}
