git:
	git add -A 
	git commit -m "[Update] README.md: Add tree"
	git push -u origin Laboratorios

purge:
	find . -type d -name bin -o -name Debug | xargs rm -rf


FOLDER_LAB := $(wildcard Laboratorio*/)
zip_lab:
	for dir in $(FOLDER_LAB); do \
		zip -r "$$(dir%/).zip $$dir"; \
	done
