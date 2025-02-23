# Unexpected Default Values When Accessing Uninitialized Properties in C#

This repository demonstrates a common, yet subtle, error in C# related to accessing properties before they've been assigned values.

## The Problem

In C#, if you access a class property before explicitly setting it, you get the default value for that type (0 for integers, false for booleans, null for reference types, etc.) This can lead to difficult-to-debug problems, especially if you are expecting null or an exception.

## The Solution

The best solution is to always explicitly initialize properties within the class's constructor (or use auto-properties with default values if applicable).