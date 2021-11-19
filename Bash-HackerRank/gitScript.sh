#!/usr/bin/bash

#Prompt the user
echo "enter the filename you would like to add. Include to file extension"


#accept user input
read name

#Filter only .txt, .md, .sh, .png files

save the extension abbrreviation as ext
ext="${name##*.}"

if (( $ext == "txt" || $ext == "md" || $ext == "sh" || $ext == "png" ))
then
	#add the entered file to staging
	git add $name

	#Prompt user for commit message
	echo "please enter the commit message

	#accept user input
	read name

	#commit the staged files 
	git commit -m "$message"

	#push the commit
	git push

else
	echo "that file will not be accepted"
fi

