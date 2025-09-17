git:
	git add -A 
	git commit -m "[Update] README.md: Add tree"
	git push -u origin Laboratorios

purge:
	find . -type d -name bin -o -name Debug | xargs rm -rf

