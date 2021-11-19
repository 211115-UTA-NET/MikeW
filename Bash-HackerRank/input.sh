#!/usr/bin/bash


read input
While IFS= read -r line
do
Echo “$line”
Done < “$input”

