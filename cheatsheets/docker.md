# Docker Cheat Sheet

## Basic commands

- `docker info` displays docker information.
- `docker version` displays the docker version in use.
- `docker version --format '{{.Server.Version}}'` displays the server version.
- `docker version --format '{{json .}}'` displays the docker version as raw json data.

## Container lifecycle

- `docker create` creates a container but does not start it.
- `docker rename` allows the container to be renamed.
- `docker run` creates and starts a container in one operation.
- `docker rm` deletes a container.
- `docker update` updates a container's resource limits.

## Starting and stopping containers

- `docker start` starts a container so it is running.
- `docker stop` stops a running container.
- `docker restart` stops and starts a container.
- `docker pause` pauses a running container, "freezing" it in place.
- `docker unpause` will unpause a running container.
- `docker wait` blocks until running container stops.
- `docker kill` sends a `sigkill` to a running container.
- `docker attach` will connect to a running container.

## Container info

- `docker ps` shows running containers.
- `docker logs` gets logs from container (you can use a custom log driver, but `logs` is only available for json-file and journald in 1.10).
- `docker inspect` looks at all the info on a container (including ip address).
- `docker events` gets events from container.
- `docker port` shows public facing port of container.
- `docker top` shows running processes in container.
- `docker stats` shows containers' resource usage statistics.
- `docker diff` shows changed files in the container's file system.

## Image lifecycle

- `docker images` shows all images.
- `docker import` creates an image from a tarball.
- `docker build` creates image from dockerfile.
- `docker commit` creates image from a container, pausing it temporarily if it is running.
- `docker rmi` removes an image.
- `docker load` loads an image from a tar archive as `stdin`, including images and tags (as of 0.7).
- `docker save` saves an image to a tar archive stream to `stdout` with all parent layers, tags & versions (as of 0.7).

## Image info

- `docker history` shows history of image.
- `docker tag` tags an image to a name (local or registry).

## Network lifecycle

- `docker network create new-network-name` creates a new network (default type: bridge).
- `docker network rm network-name` removes one or more networks by name or identifier (no containers can be connected to the network when deleting it).

## Network info

- `docker network ls` lists networks.
- `docker network inspect network-name` displays detailed information on one or more networks.

## Network connection

- `docker network connect network-container-name` connects a container to a network.
- `docker network disconnect network-container-name` disconnects a container from a network.

## Resources

- [Docker CheatSheet (LeCoupa)](https://github.com/LeCoupa/awesome-cheatsheets/blob/master/tools/docker.sh)
