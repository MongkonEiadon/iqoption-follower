﻿using System;
using System.Threading;
using AiOption.Application.ApplicationServices;
using AiOption.Domain.Common;
using AiOption.Domain.Customers;
using AiOption.Domain.Customers.Commands;
using AiOption.Query.Customers;
using EventFlow;
using EventFlow.Queries;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace AiOption.Tradings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //TradingPersistenceService tradingPersistenceService = null;

            try
            {
                //Console.WriteLine(@"
                //                     █████╗ ██╗       ██████╗ ██████╗ ████████╗██╗ ██████╗ ███╗   ██╗
                //                    ██╔══██╗██║      ██╔═══██╗██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║
                //                    ███████║██║█████╗██║   ██║██████╔╝   ██║   ██║██║   ██║██╔██╗ ██║
                //                    ██╔══██║██║╚════╝██║   ██║██╔═══╝    ██║   ██║██║   ██║██║╚██╗██║
                //                    ██║  ██║██║      ╚██████╔╝██║        ██║   ██║╚██████╔╝██║ ╚████║
                //                    ╚═╝  ╚═╝╚═╝       ╚═════╝ ╚═╝        ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝");
                var services = new ServiceCollection();
                var container = new Startup().ConfigureServices();
                var process = container.GetService<IIqAccountProcessManagerService>();

                ////migrate

                //var cust = process.RegisterCustomerAsync("m@email.com", "password", "invitationCode").Result;

                //process.ChangeCustomerLevel(cust.Id, new Level(UserLevel.Standard));

                process.ProcessRegisterNewAccountTask(CustomerId.With(""), "m@email.com", "Password", "AnyToken").Wait();


                //var query = container.GetService<IQueryProcessor>();
                //var resultModel = query.ProcessAsync(new ReadModelByIdQuery<CustomerReadModel>(accountId), CancellationToken.None)
                //    .Result;

                //Validate mapper
                //var mapper = container.GetService<IMapper>();
                //mapper.ConfigurationProvider.AssertConfigurationIsValid();


                //var trader = container.GetService<TraderPersistenceService>();
                //var follower = container.GetService<FollowerPersistenceService>();

                //trader.AppendAccountTask(new Account
                //{
                //    UserName = "mongkon.eiadon@gmail.com2",
                //    Password = "Code11054"
                //}).ConfigureAwait(false);


                //follower.AppendAccountTask(new Account
                //{
                //    UserName = "liie.m@excelbangkok.com",
                //    Password = "Code11054"
                //}).ConfigureAwait(false);

                //Task.WhenAll(trader.InitialAccount(), follower.InitialAccount());


                while (true)
                {
                    var input = Console.ReadLine();

                    switch (input)
                    {
                        case "-l":
                        {
                            //tradingPersistenceService.GetListOfSubscribe();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}