int image_count = 500;

size(256, 256);

textSize(width / 2);
textAlign(CENTER, CENTER);

for (int i = 0; i < image_count; i++) {
  background(128);
  text(i, width / 2, height / 2);
  save("image" + nf(i, 3) + ".png");
}

