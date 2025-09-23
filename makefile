git:
	git add -A 
	git commit -m "[Update] lab5"
	git push -u origin Laboratorios

purge:
	find ./ -type f -name "*.zip" -exec rm {} \;
	find . -type d -name bin -o -name Debug | xargs rm -rf


FOLDER_LAB := $(wildcard Laboratorio*/)
zip:
	for dir in $(FOLDER_LAB); do \
		zip -r "$${dir%/}.zip" "$$dir"; \
	done

zip_move:
	mv ./*.zip ~/Documents/
