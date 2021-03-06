﻿namespace Iterator
{
    interface IBookNumerable
    {
        IBookIterator CreateIterator();
        int Count { get; }
        Book this[int index] { get; }
    }
}