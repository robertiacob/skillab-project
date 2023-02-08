FROM library/postgres
EXPOSE 80
ENV POSTGRES_PASSWORD docker
ENV POSTGRES_DB docker

COPY init.sql /docker-entrypoint-initdb.d/

