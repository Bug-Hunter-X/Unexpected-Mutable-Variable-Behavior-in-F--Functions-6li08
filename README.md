# Unexpected Mutable Variable Behavior in F# Functions

This repository demonstrates an unexpected behavior involving mutable variables within F# functions. The example showcases how mutable variables can behave differently than anticipated, leading to incorrect results.

## Description

The F# code illustrates a scenario where the values of mutable variables are modified within functions. However, the actual values differ from what is expected. This issue highlights a potential pitfall when working with mutable variables in F# functions.

## Bug

The `add2` and `add3` functions are designed to modify mutable variables and return the sum.  However, the output is not as predicted due to the way F# handles mutable variables in nested scopes.

## Solution

The solution addresses the issue by explaining the underlying mechanism and providing an alternative approach using immutability.