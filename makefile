git:
	git add -A 
	git commit -m "[Update]"
	git push -u origin Laboratorios

purge:
	find . -type d -name bin -o -name Debug | xargs rm -rf

