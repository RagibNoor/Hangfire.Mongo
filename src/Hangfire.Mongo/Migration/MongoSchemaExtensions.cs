﻿using System;
using System.Collections.Generic;

namespace Hangfire.Mongo.Migration
{

    /// <summary>
    /// Helpers for MongoSchema
    /// </summary>
    public static class MongoSchemaExtensions
    {
        /// <summary>
        /// Gets collection names for given schema
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static IList<string> CollectionNames(this MongoSchema schema, string prefix)
        {
            switch (schema)
            {
                case MongoSchema.None:
                    return new[] {
                        "_identifiers", // A bug prevented the use of prefix
                        prefix + ".aggregatedcounter",
                        prefix + ".counter",
                        prefix + ".hash",
                        prefix + ".job",
                        prefix + ".jobParameter",
                        prefix + ".jobQueue",
                        prefix + ".list",
                        prefix + ".locks",
                        prefix + ".server",
                        prefix + ".set",
                        prefix + ".state",
                    };

                case MongoSchema.Version04:
                    return new[] {
                        "_identifiers", // A bug prevented the use of prefix
                        prefix + ".aggregatedcounter",
                        prefix + ".counter",
                        prefix + ".hash",
                        prefix + ".job",
                        prefix + ".jobParameter",
                        prefix + ".jobQueue",
                        prefix + ".list",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server",
                        prefix + ".set",
                        prefix + ".state",
                    };

                case MongoSchema.Version05:
                    return new[] {
                        "_identifiers", // A bug prevented the use of prefix
                        prefix + ".aggregatedcounter",
                        prefix + ".counter",
                        prefix + ".hash",
                        prefix + ".job",
                        prefix + ".jobParameter",
                        prefix + ".jobQueue",
                        prefix + ".list",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server",
                        prefix + ".set",
                        prefix + ".state",
                    };

                case MongoSchema.Version06:
                    return new[] {
                        prefix + ".job",
                        prefix + ".jobQueue",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server",
                        prefix + ".statedata"
                    };

                case MongoSchema.Version07:
                case MongoSchema.Version08:
                    return new[] {
                        prefix + ".job",
                        prefix + ".jobQueue",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server",
                        prefix + ".stateData"
                    };

                case MongoSchema.Version09:
                case MongoSchema.Version10:
                case MongoSchema.Version11:
                case MongoSchema.Version12:
                    return new[] {
                        prefix + ".job",
                        prefix + ".jobQueue",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server",
                        prefix + ".signal",
                        prefix + ".stateData"
                    };
                
                case MongoSchema.Version13:
                case MongoSchema.Version14:
                return new[]
                    {
                        prefix + ".jobGraph",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server",
                        prefix + ".signal"
                    };
                case MongoSchema.Version15:
                case MongoSchema.Version16:
                    return new[]
                    {
                        prefix + ".jobGraph",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server"
                    };
                case MongoSchema.Version17:
                    return new[]
                    {
                        prefix + ".jobGraph",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server",
                        prefix + ".notifications"
                    };
                case MongoSchema.Version18:
                    return new[]
                    {
                        prefix + ".jobGraph",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server",
                        prefix + ".notifications"
                    };
                case MongoSchema.Version19:
                    return new[]
                    {
                        prefix + ".jobGraph",
                        prefix + ".locks",
                        prefix + ".schema",
                        prefix + ".server",
                        prefix + ".notifications"
                    };
                default:
                    throw new ArgumentException($@"Unknown schema: '{schema}'", nameof(schema));
            }
        }
    }
}