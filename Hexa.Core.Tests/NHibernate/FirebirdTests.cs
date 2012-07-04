﻿namespace Hexa.Core.Tests.Sql
{
    using System.Configuration;
    using Core.Data;
    using Core.Domain;
    using NUnit.Framework;

    [TestFixture]
    public class FirebirdTests : BaseDatabaseTest
    {
        protected override NHContextFactory CreateNHContextFactory()
        {
            return new NHContextFactory(DbProvider.Firebird, ConnectionString(), string.Empty, typeof(Entity).Assembly,
                                        ApplicationContext.Container);
        }

        protected override string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Firebird.Connection"].ConnectionString;
        }
    }
}