git:
	git add -A 
	git commit -m $(comm)
	git push -u origin Laboratorios

purge:
	find ./ -type f -name "*.zip" -exec rm {} \;
	find . -type d -name bin -o -name Debug | xargs rm -rf

zip_example:
	zip -r ./Laboratorio11.zip Laboratorio11

# FOLDER_LAB := $(wildcard Laboratorio*/)
zip:
	for dir in $(FOLDER_LAB); do \
		zip -r "$${dir%/}.zip" "$$dir"; \
	done

zip_move:
	mv ./*.zip ~/Documents/


zip_and_move:
	for dir in $(FOLDER_LAB); do \
		zip -r "$${dir%/}.zip" "$$dir"; \
	done
	mv ./*.zip ~/Documents/
