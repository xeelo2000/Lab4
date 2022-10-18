﻿using System;
namespace Lab4
{
    public enum InvalidFieldError
    {
        InvalidClueLength,
        InvalidAnswerLength,
        InvalidDifficulty,
        InvalidDate,
        NoError
    }

    public enum EntryDeletionError
    {
        EntryNotFound,
        DBDeletionError,
        NoError
    }

    public enum EntryEditError
    {
        EntryNotFound,
        InvalidFieldError,
        DBEditError,
        NoError
    }

    public enum SortByClueError
    {
        SortByClueError,
        NoError
    }

    public enum SortByAnswerError
    {
        SortByAnswerError,
        NoError
    }
}

