using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using SpecFlow.Autofac;
using TechTalk.SpecFlow;

namespace NewWebPortal.Specs.Dependencies
{
    public static class TestDependencies
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder() {
            var builder = new ContainerBuilder();
            builder.RegisterTypes(typeof(TestDependencies).Assembly.GetTypes().Where(t => Attribute.IsDefined(t, typeof(BindingAttribute))).ToArray()).SingleInstance();
            return builder;
        }

    }
}