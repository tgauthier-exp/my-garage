# it's a good idea to pin this, but for demo purposes we'll leave it as is
FROM node:20.11.1 AS builder
# automatically creates the dir and sets it as the current working dir
WORKDIR /usr/src/app
# this will allow us to run vite and other tools directly
ENV PATH /usr/src/node_modules/.bin:$PATH
EXPOSE 44340
COPY package*.json ./
RUN npm install

# use a more specific COPY, as this will include files like `Dockerfile`, we don't really need inside our containers.
COPY . ./

FROM builder AS dev-builder
RUN npm run build --mode development
# it's a good idea to pin this, but for demo purposes we'll leave it as is
FROM nginx:1.25.4 AS dev
COPY --from=dev-builder /usr/src/app/dist /usr/share/nginx/html
CMD ["nginx", "-g", "daemon off;"]