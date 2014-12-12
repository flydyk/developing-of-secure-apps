﻿using System;

namespace Laba2_hash_algorithms.Cryptography.HashAlgorithms
{
    public class Sha384 : HashAlgorithm
    {
        public override byte[] CalculateHash(byte[] bytes)
        {
            var sha = new Sha384Internal();
            var hash = sha.ComputeHash(bytes);

            return hash;
        }

    }
}