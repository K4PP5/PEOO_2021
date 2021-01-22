file=$(ls -Rt */*.cs *.cs | head -n1)
mcs -out:../main.exe $file ; mono ../main.exe